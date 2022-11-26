//Task15
Console.Clear();
Console.WriteLine("Введите число от 1 до 7: ");
int n = Convert.ToInt32(Console.ReadLine());
if (n == 6 || n == 7)
{
    Console.WriteLine("Выходной день! Ура!");
}
else
    Console.Write("Будний день...");