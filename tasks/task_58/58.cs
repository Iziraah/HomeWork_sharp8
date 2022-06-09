//Задайте две матрицы. Напишите программу, которая будет
//находить произведение двух матриц.

Console.WriteLine("ВВедите количество строк первого массива массива: ");
int rows1 = int.Parse(Console.ReadLine());
Console.WriteLine("ВВедите количество столбцов первого массива массива: ");
int cols1 = int.Parse(Console.ReadLine());
Console.WriteLine("ВВедите количество строк второго массива массива: ");
int rows2 = int.Parse(Console.ReadLine());
Console.WriteLine("ВВедите количество столбцов второго массива массива: ");
int cols2 = int.Parse(Console.ReadLine());

int[,] GetArray(int row1, int col1)
{
    int[,] array = new int[row1, col1];
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
int[,] arrayResult = GetArray(rows1, cols1);
Console.WriteLine("Исходный массив1:");
PrintArray(arrayResult);
int[,] arrayResult2 = GetArray(rows2, cols2);
Console.WriteLine("Исходный массив2:");
PrintArray(arrayResult2);

int[,] GetMultiplication(int[,] arrayResult, int[,] arrayResult2)
{
    int[,] resultMatrix = new int[rows1, cols2];
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

if (rows1 == cols2)
{
    GetMultiplication(arrayResult, arrayResult2);
    Console.WriteLine("Результат умножения двух матриц");
    int[,] getResult = GetMultiplication(arrayResult, arrayResult2);
    PrintArray(getResult);
}
else
{
    Console.WriteLine("Матрицы таких размеров цмножить невозможно");
}
