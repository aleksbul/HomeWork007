// Задача 47: Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.

double[,] CreateRandomArray(int rows, int columns, int start, int end)
{
    double[,] result = new double[rows, columns];

    for (int i = 0; i < result.GetLength(0); i++)
    {
        for (int j = 0; j < result.GetLength(1); j++)
        {
            result[i, j] = Math.Round((new Random().NextDouble() * (end - start) + start), 1);
        }
    }
    return result;
}

void PrintArray(double[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"{array[i, j]}\t");
        }
        Console.WriteLine();
    }
}

Console.WriteLine("Введите количество строк: ");
int rows = int.Parse(Console.ReadLine());

Console.WriteLine("Введите количество столбцов: ");
int columns = int.Parse(Console.ReadLine());

double[,] array = CreateRandomArray(rows, columns, -20, 20);
PrintArray(array);
