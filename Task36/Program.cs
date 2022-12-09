// Task36
//  Задайте одномерный массив, заполненный случайными числами. 
// Найдите сумму элементов, стоящих на нечётных позициях.

Console.Clear();
Console.WriteLine("Введите размер массива: ");
int n = Convert.ToInt32(Console.ReadLine());
int[] array = new int[n];
InputArray(array);
Console.WriteLine($"[{string.Join(",  ", array)}]");
RealeseArray(array);

int NegativIndex = 0;

for (int i = 1; i < array.Length; i += 2)
{
    NegativIndex += array[i];
}
Console.WriteLine($"Сумма элементов стоящих на нечетных позициях: {NegativIndex} ");
void InputArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(-100, 101);
    }
}

void RealeseArray(int[] array)
{
    for (int i = 0; i < array.Length; i++);
}
