// Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

void FillArrayWithRandom(double[,] matrix, int rows, int colons)
{
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < colons; j++)
        {
            matrix[i, j] = new Random().Next(1, 11);
            Console.Write(matrix[i, j] + "\t");
        }
        Console.WriteLine();
    }
}

double Average(double[,] matrix, int rows, int colon)
{
    double sum = 0;
    double average = 0;
    for (int i = 0; i < rows; i++)
    {
        for (int j = colon-1; j < colon; j++)
        {
            sum += matrix[i,j];
        }
        average = Math.Round(sum/rows, 2);
    }
    return average;
}

int rows = 3;
int colons = 4;
double[,] matrix = new double[rows, colons];
Console.WriteLine();
FillArrayWithRandom(matrix, rows, colons);
Console.WriteLine();
double average1 = Average(matrix, rows, 1);
Console.WriteLine($"Среднее арифметическое чисел в 1 столбце:{average1}");
double average2 = Average(matrix, rows, 2);
Console.WriteLine($"Среднее арифметическое чисел во 2 столбце:{average2}");
double average3 = Average(matrix, rows, 3);
Console.WriteLine($"Среднее арифметическое чисел в 3 столбце:{average3}");
double average4 = Average(matrix, rows, 4);
Console.WriteLine($"Среднее арифметическое чисел в 4 столбце:{average4}");