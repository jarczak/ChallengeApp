using ChallengeApp;
using System.Diagnostics;

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
    public Statistics GetStatisticsWithDoWhile ()
    {
        var statistics = new Statistics();
        statistics.Max = float.MinValue;
        statistics.Min = float.MaxValue;
        statistics.Average = 0;
        var index = 0;

        do
        {
            statistics.Max = Math.Max(statistics.Max, grades[index]);
            statistics.Min = Math.Min(statistics.Min, grades[index]);
            statistics.Average += grades[index];
        }
        while (index < grades.Count);
        statistics.Average /= grades.Count;

        return statistics;
    }
    public Statistics GetStatisticsWithWhile()
    {
        var statistics = new Statistics();
        statistics.Max = float.MinValue;
        statistics.Min = float.MaxValue;
        statistics.Average = 0;
        var index = 0;

        while (index < grades.Count);
        {
            statistics.Max = Math.Max(statistics.Max, grades[index]);
            statistics.Min = Math.Min(statistics.Min, grades[index]);
            statistics.Average += grades[index];
        }
        
        statistics.Average /= grades.Count;

        return statistics;
    }
    public Statistics GetStatisticsWithFor()
    {
        var statistics = new Statistics();
        statistics.Max = float.MinValue;
        statistics.Min = float.MaxValue;
        statistics.Average = 0;
        for (var i = 0; i < grades.Count; i++)
        {
            statistics.Max = Math.Max(statistics.Max, grades[i]);
            statistics.Min = Math.Min(statistics.Min, grades[i]);
            statistics.Average += grades[i];
        }
        statistics.Average /= grades.Count;

        return statistics;
    }

}
