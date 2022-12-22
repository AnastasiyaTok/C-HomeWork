Console.Clear();
Console.WriteLine("Введите число A от 1 до 10: ");
int A = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число B от 1 до 15: ");
int B = Convert.ToInt32(Console.ReadLine());

int sumrec( int A, int B)
{
  if( A > B ) 
    return 0;
  else return A + sumrec(A+1,B);
}
Console.WriteLine($"Сумма натуральных чисел равна: {sumrec(A,B)}");
