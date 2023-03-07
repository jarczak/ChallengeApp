Employee emp1 = new Employee("Rafał", "Kraczaj", 30);
Employee emp2 = new Employee("Andrzej", "Miły", 42);
Employee emp3 = new Employee("Natalia", "Kowalska", 34);

emp1.AddScore(8);
emp1.AddScore(2);
emp1.AddScore(6);
emp1.AddScore(3);
emp1.AddScore(7);

emp2.AddScore(2);
emp2.AddScore(9);
emp2.AddScore(5);
emp2.AddScore(1);
emp2.AddScore(10);

emp3.AddScore(5);
emp3.AddScore(4);
emp3.AddScore(2);
emp3.AddScore(10);
emp3.AddScore(8);

Employee.ShowScores(emp1, emp2, emp3);