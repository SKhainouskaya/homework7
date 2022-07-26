/* Задача 47: Задайте двумерный массив размером m×n,
заполненный случайными вещественными числами. */

/* void Print(double [,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            Console.Write(Math.Round(arr[i, j], 2) + "\t");
        }
        Console.WriteLine();
    }
}
Console.WriteLine("Введите количество строк, n");
int n = int.Parse(Console.ReadLine());
Console.WriteLine("Введите количество столбцов, m");
int m = int.Parse(Console.ReadLine());

double[,] mass = new double[n, m];
for (int i = 0; i < mass.GetLength(0); i++)
{
    for (int j = 0; j < mass.GetLength(1); j++)
    {
        mass[i, j] = new Random().Next(-9, 10) + new Random().NextDouble();
    }
}
Print(mass); */

/* Задача 50: Напишите программу, которая на вход
принимает позиции элемента в двумерном массиве, и
возвращает значение этого элемента или же указание,
что такого элемента нет. */

/* void Print(int[,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            Console.Write(arr[i, j] + "\t");
        }
        Console.WriteLine();
    }
}

Console.WriteLine("Введите номер строки элемента");
int n = int.Parse(Console.ReadLine());
Console.WriteLine("Введите номер столбца элемента");
int m = int.Parse(Console.ReadLine());
int[,] mass = new int[4, 4];
for (int i = 0; i < mass.GetLength(0); i++)
{
    for (int j = 0; j < mass.GetLength(1); j++)
    {
        mass[i, j] = new Random().Next(0, 10);
    }
}
Print(mass);
Console.WriteLine();
if (n > mass.GetLength(0) || m > mass.GetLength(1))
{
    Console.WriteLine("Такой позиции в массиве нет");
}
else
{
    Console.WriteLine(mass[n-1, m-1]);
} */

/* Задача 52: Задайте двумерный массив из целых чисел.
Найдите среднее арифметическое элементов в каждом
столбце. */

int[,] mass = new int[4, 4];
double[] summ = new double[mass.GetLength(1)];
double average = 0;
FillArray(mass);
Print(mass);
for (int i = 0; i < mass.GetLength(1); i++)
{
    for (int j = 0; j < mass.GetLength(0); j++)
    {
        summ[i] += mass[j, i];
    }
    average = summ[i] / mass.GetLength(0);
    Console.Write($"Сумма по столбцу {i + 1}: {summ[i]}");
    Console.WriteLine($"\t Среднее арифметическое по столбцу {i + 1}: {Math.Round(average, 2)}");
}

int[,] FillArray(int[,] array)
{
    for (int i = 0; i < mass.GetLength(0); i++)
    {
        for (int j = 0; j < mass.GetLength(1); j++)
        {
            mass[i, j] = new Random().Next(0, 10);
        }
    }
    return array;
}
void Print(int[,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            Console.Write(mass[i, j] + "\t");
        }
        Console.WriteLine();
    }
}