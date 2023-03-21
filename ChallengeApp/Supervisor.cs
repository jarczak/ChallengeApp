namespace ChallengeApp
{
    class Supervisor : IEmployee
    {

        private List<float> grades = new List<float>();
        public Supervisor(string name, string surname)
        {
            this.Name = name;
            this.Surname = surname;
            
        }

        public string Name { get; set; }

        public string Surname { get; set; }
    
        public void AddGrade(float grade)
        {
            if (grade >= 0 && grade <= 100)
            {
                this.grades.Add(grade);
            }
            else
            {
                throw new Exception("Invalid grade value!");
            }
        }

        public void AddGrade(string grade)
        {
            switch (grade)
            {
                case "6":
                    this.grades.Add(100);
                    break;
                case "5+":
                case "+5":
                    this.grades.Add(90);
                    break;
                case "5":
                    this.grades.Add(80);
                    break;
                case "-5":
                case "5-":
                    this.grades.Add(70);
                    break;
                case "4+":
                case "+4":
                    this.grades.Add(60);
                    break;
                case "4":
                    this.grades.Add(50);
                    break;
                case "-4":
                case "4-":
                    this.grades.Add(40);
                    break;
                case "3+":
                case "+3":
                    this.grades.Add(30);
                    break;
                case "3":
                    this.grades.Add(20);
                    break;
                case "-3":
                case "3-":
                    this.grades.Add(10);
                    break;
                default:
                    throw new Exception("Wrong grade");
            }
        }

        public void AddGrade(char grade)
        {
            switch (grade)
            {
                case 'A':
                case 'a':
                    this.grades.Add(80);
                    break;
                case 'B':
                case 'b':
                    this.grades.Add(60);
                    break;
                case 'C':
                case 'c':
                    this.grades.Add(40);
                    break;
                case 'D':
                case 'd':
                    this.grades.Add(20);
                    break;
                default:
                    throw new Exception("Wrong letter!");
            }
        }

        public Statistics GetStatistics()
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
