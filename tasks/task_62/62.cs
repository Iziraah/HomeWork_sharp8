// Заполните спирально массив 4 на 4.


int rows = 4;
int cols = 4;

int[,] GetArray(int row, int col)
{
    int[,] array = new int[row, col];
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = 0;
        }
    }
    return array;
}
int[,] arrayResult = GetArray(rows, cols);
//Console.WriteLine("Исходный массив:");
//PrintArray(arrayResult);

int GetSpiral(int row, int col)
{
    int arrayResult;
    // int[,] array = new int[row, col];
    if (arrayResult[i, j] == 0)
        for (int i = 0; i < arrayResult.GetLength(0); i++)
        {
            for (int j = 0; j < arrayResult.GetLength(1); j++)
            {
                for (j = 4; j < arrayResult.GetLenght(1);)
                {
                    for (int i = 4; i < arrayResult.GetLenght(0); i--)
                    {
                        arrayResult[i, j] = 0;
                        arrayResult[i, j]++;
                    }
                }

                //array[i, j] = 0;
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
//int[,] arrayResult = GetArray(rows, cols);
//Console.WriteLine("Исходный массив:");
//PrintArray(arrayResult);
int[,] spiral = GetSpiral(row,col);
PrintArray(spiral);

