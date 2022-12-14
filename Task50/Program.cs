// Task50
// Напишите программу, которая на вход принимает позиции элемента в двумерном массиве,
// и возвращает значение этого элемента или же указание, что такого элемента нет.

Console.Clear();
Console.Write("Введите строку массива: ");
int position1 = Convert.ToInt32(Console.ReadLine()) - 1;
Console.Write("Введите столбец массива: ");
int position2 = Convert.ToInt32(Console.ReadLine()) - 1;
int n = 5; 
int m = 5; 
Random random = new Random();
int[,] matrix = new int[n, m];
Console.WriteLine("Исходный массив: ");
for (int i = 0; i < matrix.GetLength(0); i++)
{
    for (int j = 0; j < matrix.GetLength(1); j++)
{
    matrix[i, j] = new Random().Next(10, 99);
Console.Write($"{matrix[i, j]} \t");
}
Console.WriteLine();
}
    if (position1 < 0 | position1 > matrix.GetLength(0) - 1 | position2 < 0 | position2 > matrix.GetLength(1) - 1)
{
Console.WriteLine("Элемента не существует  ");
}
    else
{
    Console.WriteLine("Значение элемента массива: {0} ", matrix[position1, position2]);
}