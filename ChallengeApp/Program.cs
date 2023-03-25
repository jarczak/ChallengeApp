using ChallengeApp;

Console.WriteLine("Witamy w programie XYZ do oceny pracownika!");
Console.WriteLine("===========================================");
Console.WriteLine();
var emp = new EmployeeInMemory("Rafał", "Kraczaj");
emp.AddGrade(3.6f);
emp.AddGrade('D');
emp.AddGrade(34);
emp.AddGrade(10f);
emp.GradeAdded += EmployeeGradeAdded;

void EmployeeGradeAdded(object sender, EventArgs args)
{
    Console.WriteLine("Dodano nową ocenę");
}

while (true)
{
    Console.WriteLine("Podaj ocenę pracownika: (podaj q aby zakończyć dodawanie)");
    var input = Console.ReadLine();
    if (input == "q" || input == "Q")
    {
        break;
    }
    try
    {
        emp.AddGrade(input);
    }
    catch (Exception e)
    {
        Console.WriteLine($"An exception occured: {e}");
    }
}
var stat = emp.GetStatistics();
Console.WriteLine($"Statystyki dla pracownika: {emp.Name}, {emp.Surname}");
Console.WriteLine($"Średnia ocen: {stat.Average}");
Console.WriteLine($"Najniższa ocena: {stat.Min}");
Console.WriteLine($"Najwyższa ocena: {stat.Max}");
Console.WriteLine($"Ocena literowa: {stat.AverageLetter}");

