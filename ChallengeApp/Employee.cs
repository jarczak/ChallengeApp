class Employee
{
    private List<int> Score { get; }
    private string Name { get; }
    private string Surname { get; }
    private int Age { get; }

    public Employee (string name, string surname, int age)
    {
        Name = name;
        Surname = surname;
        Age = age;
        Score = new List<int> ();
    }

    private int Result { get
        {
            return Score.Sum();
        } 
    }


    public static void ShowScores (Employee emp1, Employee emp2, Employee emp3)
    {
        var emp1Scores = emp1.Result;
        var emp2Scores = emp2.Result;
        var emp3Scores = emp3.Result;

        if (emp1Scores > emp2Scores || emp1Scores > emp2Scores)
        {
            Console.WriteLine(emp1.Name + emp1.Surname + emp1.Result);
        }
        else if (emp2Scores > emp3Scores || emp2Scores > emp1Scores)
        {
            Console.WriteLine(emp2.Name + emp2.Surname + emp2.Result);
        }
        else
            Console.WriteLine(emp3.Name + emp3.Surname + emp3.Result);
    }
    public void AddScore (int score)
    {
        Score.Add (score);
    }

}
