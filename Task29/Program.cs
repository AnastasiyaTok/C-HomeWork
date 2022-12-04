// Task29
// Напишите программу, которая задаёт массив из 8 элементов, запрашивает данные(элементы массива) у пользователя и выводит их на экран.

Console.Clear();
Console.Write("Введите кол-во элементов: ");
int n = Convert.ToInt32(Console.ReadLine());
int[] array = new int[n];
for (int i = 0; i < array.Length; i++)
{
    Console.Write("Введите элемент массива: ");
    array[i] = Convert.ToInt32(Console.ReadLine());
}
Console.WriteLine($"[{string.Join(",    ", array)}]");
