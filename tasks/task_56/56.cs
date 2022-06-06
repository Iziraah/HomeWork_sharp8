//Задайте прямоугольный двумерный массив. Напишите
//программу, которая будет находить строку с наименьшей суммой элементов.

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
Console.WriteLine("Исходный массив:");
PrintArray(arrayResult);


void GetSum()
{
    int Imin = 0;
    int SumMin = 0;
    int sum = 0;
    for (int j = 0; j < cols; j++)
    {
        SumMin += arrayResult[0, j];
    }

    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < cols; j++)
        {
            sum += arrayResult[i, j];
        }
        int NewSum = sum;
        if (SumMin > NewSum)
        {
            SumMin = NewSum;
            sum = 0;
            Imin = i;
        }
        else
        {
            sum = 0;
        }


    }
    Console.WriteLine();
    Console.WriteLine($"Наименьшая сумма элементов ({SumMin}) находится на {Imin + 1} строке");
    }
GetSum();