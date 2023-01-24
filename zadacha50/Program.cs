// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, 
// и возвращает значение этого элемента или же указание, что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 1, 7(ввод индексов) -> такого числа в массиве нет
// 1, 1 -> 9

void FillArrayWithRandom(int[,] matrix, int m, int n)
{
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            matrix[i, j] = new Random().Next(-10, 11);
            Console.Write(matrix[i, j] + "\t");
        }
        Console.WriteLine();
    }
}

Console.WriteLine("Введите число m:");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число n:");
int n = Convert.ToInt32(Console.ReadLine());
int[,] matrix = new int[m, n];
FillArrayWithRandom(matrix, m, n);
Console.WriteLine("Введите номер строки:");
int rows = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите номер столбца:");
int colons = Convert.ToInt32(Console.ReadLine());
int number = 0;
if (rows <= m & colons <= n)
{
    number = matrix[rows - 1, colons - 1];
    Console.WriteLine($"На {rows} строчке {colons} столбца находится число: {number}");
}
else
{
    Console.WriteLine($"Позиции с индексом ({rows},{colons}) не существует!!! ");
}
