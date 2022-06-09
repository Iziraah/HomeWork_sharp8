// Заполните спирально массив 4 на 4.

Console.WriteLine("Задайте размер квадратной матрицы ");
int n = int.Parse(Console.ReadLine());
int m = n;

int[,] GetArray(int n, int m)
{
    int[,] array = new int[n, m];
    int num = 1;
    int circle = 0;
    for (circle = 0; circle < n - 2; circle++)
    {
        for (int i = 0 + circle; i < n - circle; i++)
        {
            array[0 + circle, i] = num;
            num++;
        }
        num--;
        for (int i = 0 + circle; i < n - circle; i++)
        {
            array[i, n - 1 - circle] = num;
            num++;
        }
        num--;
        for (int i = n - 1 - circle; i >= 0 + circle; i--)
        {
            array[n - 1 - circle, i] = num;
            num++;
        }
        num--;
        for (int i = n - 1 - circle; i >= 1 + circle; i--)
        {
            array[i, 0 + circle] = num;
            num++;
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
int[,] arrayResult = GetArray(n, m);
Console.WriteLine("Исходный массив:");
PrintArray(arrayResult);
