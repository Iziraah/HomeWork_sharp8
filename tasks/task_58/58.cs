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
    
    for (int i = 0; i < arrayResult.GetLength(0); i++)
    {
        for (int j = 0; j < arrayResult2.GetLength(1); j++)
        {
            for (int k = 0; k < arrayResult.GetLength(1); k++)
            {
                resultMatrix[i, j] += arrayResult[i, k] * arrayResult2[k, j];
                
            }
            
        }
    }
    return resultMatrix;
}
GetMultiplication(arrayResult, arrayResult2);
Console.WriteLine();
int[,] getResult = GetMultiplication(arrayResult, arrayResult2);
PrintArray(getResult);
