// Task38
//  Задайте массив вещественных чисел. 
//Найдите разницу между максимальным и минимальным элементов массива.

Console.Clear();
Console.WriteLine("Введите размер массива  ");
int n = Convert.ToInt32(Console.ReadLine());
double[] array = new double[n];
InputArray(array);
Console.WriteLine($"[{string.Join(",  ", array)}]");
ReleaseArray(array);
double min = Int32.MaxValue;
double max = Int32.MinValue;

for (int k = 0; k < array.Length; k++)
{
    if (array[k] > max)
        {
            max = array[k];
        }
    if (array[k] < min)
        {
            min = array[k];
        }
}

Console.WriteLine($"Максимальное значение = {max}, минимальное значение = {min}");
Console.WriteLine($"Разница между максимальным и минимальным значением = {max - min}");

void InputArray(double[] array)
{
    for(int i = 0; i < array.Length; i++)
        {
            array[i] = Convert.ToDouble(new Random().Next(100,1000)) / 100;
        }
}
void ReleaseArray(double[] array)
{
    for(int i = 0; i < array.Length; i++);
}