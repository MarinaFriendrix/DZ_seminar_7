// Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
// Console.Write("Введите число строк: ");
// int m = Convert.ToInt32(Console.ReadLine());

// Console.Write("Введите число столбцов: ");
// int n = Convert.ToInt32(Console.ReadLine());

// int[,] matrix = new int [m, n];

// for (int i =0; i < m; i++)
// {
//     for (int j = 0; j < n; j++)
//     {
//        matrix[i,j] = new Random().Next(1,100);
//        Console.Write($"{matrix[i, j]} ");
//     }
//     Console.WriteLine();
// }

// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве,
//  и возвращает значение этого элемента или же указание, что такого элемента нет.
// Console.Write("Введите число строк: ");
// int m = Convert.ToInt32(Console.ReadLine());

// Console.Write("Введите число столбцов: ");
// int n = Convert.ToInt32(Console.ReadLine());

// int[,] matrix = new int [m, n];

// for (int i =0; i < m; i++)
// {
//     for (int j = 0; j < n; j++)
//     {
//        matrix[i,j] = new Random().Next(1,100);
//        Console.Write($"{matrix[i, j]} ");
//     }
//     Console.WriteLine();
// }

// Console.Write("Введите номер строки: ");
// int a = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите номер столбца: ");
// int b = Convert.ToInt32(Console.ReadLine());

// if (a > m && b > n)
// {
//     Console.WriteLine("такого элемента нет");
// }
// else
// {
//     int i = a;
//     int j = b;
//     Console.WriteLine (matrix[i,j]);

// }


// Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.

Console.Write("Введите число строк: ");
int m = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите число столбцов: ");
int n = Convert.ToInt32(Console.ReadLine());

int[,] matrix = new int [m, n];

for (int i =0; i < m; i++)
{
    for (int j = 0; j < n; j++)
    {
       matrix[i,j] = new Random().Next(1,10);
       Console.Write($"{matrix[i, j]} ");
    }
    Console.WriteLine();
}
double average = 0;
for (int j =0; j < n; j++)
{
    double sum = 0;
    for (int i = 0; i < m; i++)
    {
        sum += matrix[i,j];
    }
    average = sum/m;
Console.Write(" " +Math.Round(average, 2));
}