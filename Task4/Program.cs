// Task4
Console.Clear();
Console.Write("Введите первое число: ");
int a = Convert.ToInt32(Console.ReadLine());
 Console.Write("Введите второе число: ");
int b = Convert.ToInt32(Console.ReadLine()); 
 Console.Write("Введите третье число: ");
int c = Convert.ToInt32(Console.ReadLine());
if (a > b && a > c)
    Console.Write( $" {a} Max число ");
else if (b > c)
    Console.Write( $" {b} Max число ");
else
    Console.Write( $" {c} Max число ");
