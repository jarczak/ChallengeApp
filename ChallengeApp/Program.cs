var employee = new Employee("Rafał", "Kraczaj");
employee.AddGrade(2);
employee.AddGrade(3);
employee.AddGrade(7);
employee.AddGrade(8.9f);
var stat = employee.GetStatistics();
Console.WriteLine($"Max value is {stat.Max}");
Console.WriteLine($"Min value is {stat.Min}");
Console.WriteLine($"Average value is {stat.Average}");
