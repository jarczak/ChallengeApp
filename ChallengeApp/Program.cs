int number = 43328;

string numberInString = number.ToString();
char[] arr = numberInString.ToCharArray();

int counter1 = 0;
int counter2 = 0;
int counter3 = 0;
int counter4 = 0;
int counter5 = 0;
int counter6 = 0;
int counter7 = 0;
int counter8 = 0;
int counter9 = 0;
int counter0 = 0;

foreach (char c in arr)
{
    if (c == '1')
    {
        counter1++;
    }
    if (c == '2')
    {
        counter2++;
    }
    if (c == '3')
    {
        counter3++;
    }
    if (c == '4')
    {
        counter4++;
    }
    if (c == '5')
    {
        counter5++;
    }
    if (c == '6')
    {
        counter6++;
    }
    if (c == '7')
    {
        counter7++;
    }
    if (c == '8')
    {
        counter8++;
    }
    if (c == '9')
    {
        counter9++;
    }
    if (c == '0')
    {
        counter0++;
    }
}
Console.WriteLine("For number: " + number);
Console.WriteLine("0 => " + counter0);
Console.WriteLine("1 => " + counter1);
Console.WriteLine("2 => " + counter2);
Console.WriteLine("3 => " + counter3);
Console.WriteLine("4 => " + counter4);
Console.WriteLine("5 => " + counter5);
Console.WriteLine("6 => " + counter6);
Console.WriteLine("7 => " + counter7);
Console.WriteLine("8 => " + counter8);
Console.WriteLine("9 => " + counter9);

