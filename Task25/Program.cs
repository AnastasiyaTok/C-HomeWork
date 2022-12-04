// Task25
// Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.

Console.Clear();
Console.WriteLine("Введите 1-ое число: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите 2-ое число: ");
int b = Convert.ToInt32(Console.ReadLine());

{
    int result = a;
    for (int i = 1; i < b; i++)
    {
        result = result * a;
    }
    Console.WriteLine(result);
}
