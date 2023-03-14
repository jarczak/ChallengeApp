using ChallengeApp;

public class Employee
{
    private List<float> grades = new List<float>();
    public Employee(string name, string surname)
    {
        this.Name = name;
        this.Surname = surname;
    }
   public string Name { get; private set; }
   public string Surname { get; private set; }

    public void AddGrade (float grade)
    {
        if (grade >= 0 && grade <= 100)
        {
            grades.Add(grade);
        }
        else
        {
            Console.WriteLine("Invalid grade value!");
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
            Console.WriteLine("String is not float!");
        }
    }
    public void AddGrade (int grade)
    {
        this.AddGrade((float)grade);
    }
    public void AddGrade (double grade)
    {
        this.AddGrade((float)grade);
    }
    public void AddGrade (byte grade)
    {
        this.AddGrade((float)grade);
    }
    public void AddGrade (long grade)
    {
        this.AddGrade((float)grade);
    }
    public void AddGrade (short grade)
    {
        this.AddGrade((float)grade);
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

        return statistics;
    }
    
}
