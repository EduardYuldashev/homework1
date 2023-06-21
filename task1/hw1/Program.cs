Console.Clear();
int max = 0;
int min = 0;

Console.Write("Введите первое число:");
string userInput1 = Console.ReadLine() ?? "";
int aNumber = int.Parse(userInput1);

Console.Write("Введите второе число:");
string userInput2 = Console.ReadLine() ?? "";
int bNumber = int.Parse(userInput2);

if(aNumber > bNumber)
{
    max = aNumber;
    min = bNumber;
}
else
{
    max = bNumber;
    min = aNumber;
}
Console.WriteLine ($"max={max}, min={min}");
