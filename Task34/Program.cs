// Task34
//  Задайте массив заполненный случайными положительными трёхзначными числами. 
// Напишите программу, которая покажет количество чётных чисел в массиве.

Console.Clear();
Console.WriteLine("Введите размер массива: ");
int n = Convert.ToInt32(Console.ReadLine());
int[] array = new int[n];
int count = 0;
InputArray(array);
Console.WriteLine($"[{string.Join(",  ", array)}]");
ReleaseArray(array);

for (int i = 0; i < array.Length; i++)
{
    if (array[i] % 2 == 0)
    count++;
}

Console.WriteLine($"Количество чётных чисел в массиве: {count} ");

void InputArray(int[] array)
{
    for(int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(100,1000);
    }
}
void ReleaseArray(int[] array)
{
    for(int i = 0; i < array.Length; i++);
   
}