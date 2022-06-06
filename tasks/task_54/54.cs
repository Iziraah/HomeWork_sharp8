// Задайте двумерный массив. Напишите программу, которая
//упорядочит по убыванию элементы каждой строки двумерного массива.


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

int[,] GetOrderInTheMatrix(int[,] arrayN)
{
    int max = 0;
    for (int i = 0; i < arrayN.GetLength(0); i++)
    {
        for (int k = 1; k < arrayN.GetLength(0); k++)
        {
           for (int j = arrayN.GetLength(1) - 1; j >=k; j--)
            {
                if (arrayN[i,j-1]<arrayN[i,j])
                {
                    max = arrayN[i, j-1];
                    arrayN[i, j-1] = arrayN[i, j];
                    arrayN[i, j] = max;


                }

            }

        }
    }
    return arrayN;
}

int[,] arrayResult = GetArray(rows, cols);
Console.WriteLine("Исходный массив:");
PrintArray(arrayResult);
Console.WriteLine();

int[,] newArray = GetOrderInTheMatrix(arrayResult);
PrintArray(newArray);