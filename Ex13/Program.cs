Console.WriteLine("Введите целое число: ");
int a = int.Parse(Console.ReadLine() ?? "0");
if (a <0)
{
    a = -a;
}
if (a < 100)
{
    Console.WriteLine($"{a} -> Третьей цифры нет");
}
else
{
    int b = a;
    while (a > 1000)
    {
        a = a / 10;
    }
    a = a % 10;
    Console.WriteLine($"{b} -> {a}");
}