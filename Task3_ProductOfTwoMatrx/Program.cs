
// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18

int GetNumber(string message)
{
    Console.WriteLine(message);
    int number = int.Parse(Console.ReadLine() ?? "");
    return number;
}

int[,] InitMatrix(int m, int n)
{
    int[,] matrix = new int[m, n];
    Random rnd = new Random();
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = rnd.Next(1, 10);
        }
    }
    return matrix;
}

void PrintMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write($"{matrix[i, j]} ");
        }
        Console.WriteLine();
    }
}

int n = GetNumber("Введите число m");
int m = GetNumber("Введите число n");
int[,] firstMatrix = InitMatrix(m, n);
int[,] secondMatrix = InitMatrix(m, n);

Console.WriteLine($"Первая матрица ");
PrintMatrix(firstMatrix);
Console.WriteLine($"Вторая матрица ");
PrintMatrix(secondMatrix);
Console.WriteLine($"Произведение двух матриц:  ");

int[,] productMatrix = productMatrix = new int[m, n];
for (int i = 0; i < productMatrix.GetLength(0); i++)
{
    for (int j = 0; j < productMatrix.GetLength(1); j++)
    {
        productMatrix[i, j] = firstMatrix[i, j] * secondMatrix[i, j];
    }
}

PrintMatrix(productMatrix);