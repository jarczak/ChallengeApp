Console.WriteLine("Witamy w programie XYZ do oceny pracownika!");
Console.WriteLine("===========================================");
Console.WriteLine();
var emp = new Employee("Rafał", "Kraczaj", "M");


while (true)
{
    Console.WriteLine("Podaj ocenę pracownika: (podaj q aby zakończyć dodawanie)");
    var input = Console.ReadLine();
    if(input == "q" || input == "Q")
    {
        break;
    }
    try
    {
        emp.AddGrade(input);
    }
    catch(Exception e) 
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

