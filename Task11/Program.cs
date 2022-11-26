// Task11
Console.Clear();
int n = new Random().Next(100, 1000);
Console.Write($"Введите случайное число: {n} ");
int n1 = n / 100;
int n3 = n % 10;
Console.WriteLine(n1 * 10 + n3);

