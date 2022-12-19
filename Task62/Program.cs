// Task62 
// Напишите программу, которая заполнит спирально массив 4 на 4.

int n = 4;
int[,] helixMatrix = new int[n, n];

int temp = 1;
int i = 0;
int j = 0;

while (temp <= helixMatrix.GetLength(0) * helixMatrix.GetLength(1))
{
  helixMatrix[i, j] = temp;
  temp++;
  if (i <= j + 1 && i + j < helixMatrix.GetLength(1) - 1)
    j++;
  else if (i < j && i + j >= helixMatrix.GetLength(0) - 1)
    i++;
  else if (i >= j && i + j > helixMatrix.GetLength(1) - 1)
    j--;
  else
    i--;
}

ReleaseMatrix(helixMatrix);

void ReleaseMatrix (int[,] matrix)
{
  for (int i = 0; i < matrix.GetLength(0); i++)
  {
    for (int j = 0; j < matrix.GetLength(1); j++)
    {
      if (matrix[i,j] / 10 <= 0)
      Console.Write($" {matrix[i,j]} ");

      else Console.Write($" {matrix[i,j] }");
    }
    Console.WriteLine();
  }
}
