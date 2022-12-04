// Task27
// Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

Console.Clear();
Console.WriteLine("Введите число: ");
int n = Convert.ToInt32(Console.ReadLine());
int summa = 0;

while (n > 0)
{
int nu = n % 10;
n = n / 10;
summa = summa + nu;
}
Console.WriteLine("Сумма всех цифр в числе равна: " + summa);
