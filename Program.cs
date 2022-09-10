// Задача 47. Задайте двумерный массив размером m×n, заполненный случайными 
// вещественными числами.
// m = 3, n = 4.
// 0,5 7 -2 -0,2
// 1 -3,3 8 -9,9
// 8 7,8 -7,1 9

/*

double[,] CreateRandom2dArray(int rows, int cols)
{
    double[,] array = new double[rows, cols];
    for (int i = 0; i < rows; i++)
        for (int j = 0; j < cols; j++)
            array[i, j] = new Random().Next(-10, 10) + new Random().NextDouble();
    return array;
}

void Show2dArray(double[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i, j].ToString("0.0") + "    ");
        }
        Console.WriteLine();
    }
}

Console.Write("Input number of rows: ");
int rows = Convert.ToInt32(Console.ReadLine());
Console.Write("Input number of cols: ");
int cols = Convert.ToInt32(Console.ReadLine());
double[,] array = CreateRandom2dArray(rows, cols);
Show2dArray(array);

*/

// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном 
// массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.
// Например, задан массив:

// 1 4 7 2
// 5 9 2 3
// 8 4 2 4

// 1,7 -> такого числа в массиве нет
// 1,2 -> 2

/*

int[,] CreateRandom2dArray(int rows, int cols)
{
    int[,] array = new int[rows, cols];
    for (int i = 0; i < rows; i++)
        for (int j = 0; j < cols; j++)
            array[i, j] = new Random().Next(1, 11);
    return array;
}

void Show2dArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i, j] + "    ");
        }
        Console.WriteLine();
    }
}

void FindAndShowElement(int[,] array)
{
    Console.Write("Введите строку элемента: ");
    int i = Convert.ToInt32(Console.ReadLine());
    Console.Write("Введите столбец элемента: ");
    int j = Convert.ToInt32(Console.ReadLine());
    if (i < 0 || i >= array.GetLength(0) || j < 0 || j >= array.GetLength(1))
    {
        Console.WriteLine("Такого элемента нет!");
    }
    else
    {
        Console.Write($"Значение элемента [{i}, {j}] = [{array[i, j]}]");
    }
}

Console.Write("Input number of rows: ");
int rows = Convert.ToInt32(Console.ReadLine());
Console.Write("Input number of cols: ");
int cols = Convert.ToInt32(Console.ReadLine());
int[,] array = CreateRandom2dArray(rows, cols);
Show2dArray(array);
FindAndShowElement(array);

*/










// Задача 52. Задайте двумерный массив из целых чисел. 
// Найдите среднее арифметическое элементов в каждом столбце.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

/*

int[,] CreateRandom2dArray(int rows, int cols)
{
    int[,] array = new int[rows, cols];
    for (int i = 0; i < rows; i++)
        for (int j = 0; j < cols; j++)
            array[i, j] = new Random().Next(1, 11);
    return array;
}

void Show2dArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i, j] + "    ");
        }
        Console.WriteLine();
    }
}

void CalcAverageRow(int[,] array)
{
    Console.WriteLine("Средние арифмтечиские значения столбцов: ");
    for (int j = 0; j < array.GetLength(1); j++)
    {
        double sum = 0;
        for (int i = 0; i < array.GetLength(0); i++)
        {
            sum += array[i, j];
        }
        Console.Write((sum / array.GetLength(0)).ToString("0.0") + "  ");
    }
}

Console.Write("Input number of rows: ");
int rows = Convert.ToInt32(Console.ReadLine());
Console.Write("Input number of cols: ");
int cols = Convert.ToInt32(Console.ReadLine());
int[,] array = CreateRandom2dArray(rows, cols);
Show2dArray(array);
CalcAverageRow(array);

*/