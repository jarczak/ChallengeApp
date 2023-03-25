using System.Diagnostics;

namespace ChallengeApp
{
    internal class EmployeeInFile : EmployeeBase
    {
        public delegate void GradeAddedDelegate(object sender, EventArgs args);
        public event GradeAddedDelegate GradeAdded;
        private const string fileName = "grades.txt";
        public EmployeeInFile(string name, string surname) : base(name, surname)
        {
        }

        public override void AddGrade(float grade)
        {
            {
                if (grade >= 0 && grade <= 100)
                {
                    using (var writer = File.AppendText(fileName))
                    {
                        writer.WriteLine(grade);
                        if (GradeAdded != null)
                        {
                            GradeAdded(this, new EventArgs());
                        }
                    }
                }
                else
                {
                    throw new Exception("Invalid grade value!");
                }
            } 
        }

        public override void AddGrade(string grade)
        {
            if (float.TryParse(grade, out float value))
            {
                this.AddGrade(value);
            }
            else
            {
                throw new Exception("String is not float!");
            }
        }

        public override void AddGrade(char grade)
        {
            switch (grade)
            {
                case 'A':
                case 'a':
                    this.AddGrade(80f);
                    break;
                case 'B':
                case 'b':
                    this.AddGrade(60f);
                    break;
                case 'C':
                case 'c':
                    this.AddGrade(40f);
                    break;
                case 'D':
                case 'd':
                    this.AddGrade(20f);
                    break;
                default:
                    throw new Exception("Wrong letter!");
            }
        }

        public override Statistics GetStatistics()
        {
            var gradesFromFile = this.ReadGradesFromFile();
            var result = this.CountStatistics(gradesFromFile);
            return result;
        }

        private List<float> ReadGradesFromFile()
        {
            var grades = new List<float>();
            if (File.Exists($"{fileName}"))
            {
                using (var reader = File.OpenText($"{ fileName}"))
                {
                    var line = reader.ReadLine();
                    while (line != null)
                    {
                        var number = float.Parse(line);
                        grades.Add(number);
                        line = reader.ReadLine();
                    }
                }    
            }
            return grades;
        }

        private Statistics CountStatistics(List<float> grades)
        {
            var statistics = new Statistics();
            statistics.Max = float.MinValue;
            statistics.Min = float.MaxValue;
            statistics.Average = 0;
            foreach (var grade in grades)
            {
                statistics.Max = Math.Max(statistics.Max, grade);
                statistics.Min = Math.Min(statistics.Min, grade);
                statistics.Average += grade;
            }
            statistics.Average /= grades.Count;

            switch (statistics.Average)
            {
                case var average when average >= 80:
                    statistics.AverageLetter = 'A';
                    break;
                case var average when average >= 60:
                    statistics.AverageLetter = 'B';
                    break;
                case var average when average >= 40:
                    statistics.AverageLetter = 'C';
                    break;
                case var average when average >= 20:
                    statistics.AverageLetter = 'D';
                    break;
                default:
                    statistics.AverageLetter = 'E';
                    break;
            }

            return statistics;
        }
    }
}

