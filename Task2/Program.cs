// Task2
Console.Clear();
Console.Write("Введите первое число: ");
int n = Convert.ToInt32(Console.ReadLine());
 Console.Write("Введите второе число: ");
int m = Convert.ToInt32(Console.ReadLine()); 
if (n < m)
    Console.Write( $" {m} Max число ");
if (m < n)
    Console.Write( $" {n} Max число ");

