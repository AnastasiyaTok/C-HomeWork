//Task13
Console.Clear();
Console.Write($"Введите любое число: ");
int n = Convert.ToInt32(Console.ReadLine());
while ( n > 999) n /= 10;

    Console.Write($"{(n % 10)}"); 

    if (n < 99)
        Console.WriteLine("Нет третьего числа");
                

   