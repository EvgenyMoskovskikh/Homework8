// Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18

Console.Write("Введите количество строк для 1-й матрицы: ");
int a = int.Parse(Console.ReadLine()!);
Console.Write("Введите количество столбцов для 1-й матрицы (и строк для 2-й): ");
int b = int.Parse(Console.ReadLine()!);
Console.Write("Введите количество столбцов для 2-й матрицы: ");
int c = int.Parse(Console.ReadLine()!);

int[,] firstMartrix = new int[a, b];
GetArray(firstMartrix);
Console.WriteLine($"Первая матрица: ");
NewGetArray(firstMartrix);

int[,] secomdMartrix = new int[b, c];
GetArray(secomdMartrix);
Console.WriteLine($"Вторая матрица: ");
NewGetArray(secomdMartrix);

int[,] resultMatrix = new int[a, c];

MultiplyMatrix(firstMartrix, secomdMartrix, resultMatrix);
Console.WriteLine($"Произведение двух матриц: ");
NewGetArray(resultMatrix);

void GetArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(10, 100);
        }
    }
}

void NewGetArray(int[,] array)
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

void MultiplyMatrix(int[,] firstMartrix, int[,] secomdMartrix, int[,] resultMatrix)
{
    for (int i = 0; i < resultMatrix.GetLength(0); i++)
    {
        for (int j = 0; j < resultMatrix.GetLength(1); j++)
        {
            int sum = 0;
            for (int z = 0; z < firstMartrix.GetLength(1); z++)
            {
                sum += firstMartrix[i, z] * secomdMartrix[z, j];
            }
            resultMatrix[i, j] = sum;
        }
    }
}