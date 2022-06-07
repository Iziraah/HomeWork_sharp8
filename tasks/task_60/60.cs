// : Сформируйте трёхмерный массив из неповторяющихся
//двузначных чисел. Напишите программу, которая будет построчно выводить
//массив, добавляя индексы каждого элемента.

Console.WriteLine("Введите количество строк по ширине массива: ");
int x = int.Parse(Console.ReadLine());
Console.WriteLine("Введите количество столбцов по высоте массива: ");
int y = int.Parse(Console.ReadLine());
Console.WriteLine("Введите количество строк в глубину массива: ");
int z = int.Parse(Console.ReadLine());

int[,,] GetArray(int x, int y, int z)
{
    int[,,] array = new int[x, y, z];
    Random rnd = new Random();
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            for (int k = 0; k < array.GetLength(2); k++)
            {
                array[i, j, k] = rnd.Next(0, 11);
                Console.Write(array[i, j, k] + "(" + i + j + k + ")" + " ;");
            }
            Console.WriteLine();
        }
    }
    return array;
}
GetArray(x, y, z);

