using ChallengeApp;

public class Employee : Person
{
    private List<float> grades = new List<float>();
    public Employee(string name, string surname, string sex)
        : base(name, surname, sex)
    {
        
    }

    public void AddGrade (float grade)
    {
        if (grade >= 0 && grade <= 100)
        {
            grades.Add(grade);
        }
        else
        {
            throw new Exception("Invalid grade value!");
        }
        
    }
    public void AddGrade (string grade)
    {
        if(float.TryParse(grade, out float value))
        {
            this.AddGrade(value);
        }
        else
        {
            throw new Exception("String is not float!");
        }
    }
    public void AddGrade (char grade)
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

    public Statistics GetStatistics ()
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
