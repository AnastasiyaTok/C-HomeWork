// Треугольник Паскаля
// Вывести первые N строк треугольник Паскаля

Console.Clear();
int n = InputMatrix("Введите количество строк: ");
double[,] pascalTriangle = new double[n + 1, 2 * n + 1];
InputPascalTriangle(pascalTriangle);
Console.WriteLine();
// ReleaseMatrix(pascalTriangle);
TransformationPascalTriangle(pascalTriangle);
Console.WriteLine();
ReleaseMatrix(pascalTriangle);
int InputMatrix(string input)
{
  Console.Write(input);
  int output = Convert.ToInt32(Console.ReadLine());
  return output;
}
void TransformationPascalTriangle(double[,] matrix)
{
  for (int i = 0; i < matrix.GetLength(0); i++)
  {
    int count = 0;
    for (int j = matrix.GetLength(1) - 1; j >= 0; j--)
    {
      if (matrix[i, j] != 0)
      {
        matrix[i, matrix.GetLength(1) / 2 + j - count] = matrix[i, j];
        matrix[i, j] = 0;
        count++;
      }
    }
  }
  matrix[matrix.GetLength(0) - 1, 0] = 1;
}
void InputPascalTriangle(double[,] pascalTriangle)
{
  for (int k = 0; k < pascalTriangle.GetLength(0); k++)
  {
    pascalTriangle[k, 0] = 1;
  }
  for (int i = 1; i < pascalTriangle.GetLength(0); i++)
  {
    for (int j = 1; j < i + 1; j++)
    {
      pascalTriangle[i, j] = pascalTriangle[i - 1, j] + pascalTriangle[i - 1, j - 1];
    }
  }
}
void ReleaseMatrix(double[,] matrix)
{
  for (int i = 0; i < matrix.GetLength(0); i++)
  {
    for (int j = 0; j < matrix.GetLength(1); j++)
    {
      if (matrix[i, j] != 0)
      {
          Console.Write($" {matrix[i, j]}");
      }
      else Console.Write("  ");
    }
    Console.WriteLine();
  }
}


