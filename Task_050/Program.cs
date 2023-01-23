// Задача 50: Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, 
// и возвращает значение этого элемента или же указание, что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4

// 17 -> такого числа в массиве нет


int[,] GetRandomArray(int rows, int columns, int start, int end)
{
    int[,] result = new int[rows, columns];

    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            result[i, j] = new Random().Next(start, end + 1);
        }
    }
    return result;
}

void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"{array[i, j]} ");
        }
        Console.WriteLine();
    }
}

int[,] array = GetRandomArray(5, 6, 0, 10);
PrintArray(array);

Console.WriteLine("Введите позицию элемента: ");
int number = int.Parse(Console.ReadLine());

int rows = array.GetLength(0);
int columns = array.GetLength(1);

if (number > rows * columns) Console.WriteLine($"{number} -> такого числа в массиве нет.");
else
{
    int position = number - 1;
    int i = position / columns;
    int j = position % columns;
    Console.WriteLine($"Значение элемента в позиции {number} -> {array[i, j]}");
}