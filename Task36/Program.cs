// Task36
//  Задайте одномерный массив, заполненный случайными числами. 
// Найдите сумму элементов, стоящих на нечётных позициях.

Console.Clear();
Console.WriteLine("Введите размер массива: ");
int n = Convert.ToInt32(Console.ReadLine());
int[] array = new int[n];

InputArray(array);
Console.WriteLine($"[{string.Join(",  ", array)}]");
ReleaseArray(array);

int IndexNegativ = 0;
for (int i = 0; i < array.Length; i += 2)
{
    IndexNegativ += array[i];
    
}

Console.WriteLine($"Сумма элементов стоящих на нечетных позициях: {IndexNegativ} ");

void InputArray(int[] array)
{
    for(int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(10,99);
    }
}
void ReleaseArray(int[] array)
{
    for(int i = 0; i < array.Length; i++);
   
}