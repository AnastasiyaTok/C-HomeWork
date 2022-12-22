// Task68
// Напишите программу вычисления функции Аккермана с помощью рекурсии. 
// Даны два неотрицательных числа m и n.

Console.Clear();
Console.Write("Введите число n: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число m: ");
int m = Convert.ToInt32(Console.ReadLine());
   Ackermann(n, m);
    static int Ackermann(int n, int m)
    {
      if (n == 0) return m + 1;
        if (n != 0 && m == 0) return Ackermann(n - 1, 1);
          if (n > 0 && m > 0) return Ackermann(n - 1, Ackermann(n, m - 1));
            return Ackermann(n,m);
    }
  Console.WriteLine(Ackermann(n,m));