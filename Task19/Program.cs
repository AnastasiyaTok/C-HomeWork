// Task19
Console.Clear();
Console.WriteLine("Введите число: ");
string n = Console.ReadLine();
int len = n.Length;

if (len == 5)
{
    if (n [0] == n [4] && n [1] == n [3])
    {
        Console.WriteLine($"{n} - Палиндром");
    }
    else
    {
        Console.WriteLine($"{n} - Не палиндром");
    }
}
else
{
    Console.WriteLine($"Введенное число: {n} - не является пятизначным");
}