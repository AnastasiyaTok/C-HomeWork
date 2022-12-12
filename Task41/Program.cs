// Task41
// Пользователь вводит с клавиатуры M чисел. 
// Посчитайте, сколько чисел больше 0 ввёл пользователь.
Console.Clear();
Console.WriteLine("Введите числа через пробел: ");
int[] n = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
int count = n.Count(i => i > 0);
Console.WriteLine($"Кол-во чисел больше 0: {count}");