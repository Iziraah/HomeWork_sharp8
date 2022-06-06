//Задайте две матрицы. Напишите программу, которая будет
//находить произведение двух матриц.

Console.WriteLine("ВВедите количество строк массива: ");
int rows = int.Parse(Console.ReadLine());
Console.WriteLine("ВВедите количество столбцов массива: ");
int cols = int.Parse(Console.ReadLine());

int[,] GetArray(int row, int col)
{
    int[,] array = new int[row, col];
    Random rnd = new Random();
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = rnd.Next(0, 11);
        }
    }
    return array;
}

void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i, j] + " ");
        }
        Console.WriteLine();
    }
}
int[,] arrayResult = GetArray(rows, cols);
Console.WriteLine("Исходный массив1:");
PrintArray(arrayResult);
int[,] arrayResult2 = GetArray(rows, cols);
Console.WriteLine("Исходный массив2:");
PrintArray(arrayResult2);

int[,] GetMultiplication(int[,] arrayResult, int[,] arrayResult2)
{
    int[,] resultMatrix = new int[rows, cols];
   // for (int i = 0; i < arr.GetLength(0); i++)
   // {
   //     for (int j = 0; j < arr.GetLength(1); j++)
   //     {
   //         arr[i, j] = (a[i,j]*b[i,j]+a[i,j+1]*b[i+1,j]+a[i,j+2]*b[i+2,j]);
   //     }
   // }
   // return arr;
   for (int i = 0; i < arrayResult.GetLength(0); i++)
        {
            for (int j = 0; j < arrayResult2.GetLength(1); j++)
            {
                for (int k = 0; k < arrayResult2.GetLength(0); k++)
                {
                   // resultMatrix[i, j] += arrayResult[i, k] * arrayResult2[k, j];
                    resultMatrix[i, j] = (arrayResult[i,j]*arrayResult2[k,j]+arrayResult[i,j+1]*arrayResult2[k+1,j]+arrayResult[i,j+2]*arrayResult2[k+2,j]);
                    Console.Write(resultMatrix[i, j] + " ");
                }
               // Console.Write(resultMatrix[i, j] + " ");
                Console.WriteLine();
            }
        }
  return resultMatrix;
}
GetMultiplication(arrayResult, arrayResult2);


