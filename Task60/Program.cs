// Task60
// Сформируйте трёхмерный массив из неповторяющихся двузначных чисел
// Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.

int[,,] matrix2 = new int[2, 2, 2];
InputMatrix(matrix2);
ReleaseMatrix(matrix2);

void ReleaseMatrix(int[,,] arr)
{
    for (int i = 0; i < matrix2.GetLength(0); i++)
    {
        for (int j = 0; j < matrix2.GetLength(1); j++)
        {
            Console.WriteLine();
            for (int k = 0; k < matrix2.GetLength(2); k++)
            {
                Console.Write($"{matrix2[i, j, k]}({i},{j},{k}) ");
            }
        }
    }
}

void InputMatrix(int[,,] arr)
{
    int count = 10;
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            for (int k = 0; k < arr.GetLength(2); k++)
            {
                arr[k, i, j] += count;
                count += 3;
            }
        }
    }
}
