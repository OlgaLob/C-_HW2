Console.Write("Введите трекхзначное число: ");
int a = int.Parse(Console.ReadLine() ?? "0");
int b = a / 10 % 10;

Console.Write(b);
