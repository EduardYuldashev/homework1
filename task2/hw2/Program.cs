Console.Clear();
int max = 0;

Console.Write("Введите первое число:");
string userInput1 = Console.ReadLine() ?? "";
int aNumber = int.Parse(userInput1);

Console.Write("Введите второе число:");
string userInput2 = Console.ReadLine() ?? "";
int bNumber = int.Parse(userInput2);

Console.Write("Введите третье число:");
string userInput3 = Console.ReadLine() ?? "";
int cNumber = int.Parse(userInput3);

if(aNumber > max)
{
    max = aNumber;
}
if(bNumber > max)
{
    max = bNumber;
}
if(cNumber > max)
{
    max = cNumber;
}
Console.WriteLine ($"max={max}");

