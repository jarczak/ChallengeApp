var name = "Ewa";
var sex = "kobieta";
var age = 33;
Console.WriteLine(name + "" + sex + "" + age);

if (sex == "kobieta" && age < 30)
{
    Console.WriteLine("Kobieta, poniżej 30 lat");
}
else
{
    Console.WriteLine(name + " lat " + age);
}

if (sex != "kobieta" && age < 18)
{
    Console.WriteLine("Niepełnoletni mężczyzna");
}

