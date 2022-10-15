// Отсортировать нечетные столбцы массива по возрастанию. Вывести массив изначальный и массив с отсортированными нечетными столбцами

Console.Write("Введите количество строк: ");
int m = int.Parse(Console.ReadLine()!);
Console.Write("Введите количество столбцов: ");
int n = int.Parse(Console.ReadLine()!);

int[,] array = new int[m, n];
GetArray(array);
PrintArray(array);

Console.WriteLine("В итоге получается вот такой массив: ");
NewGetArray(array);
PrintArray(array);

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
    int n = array.GetLength(0);
    int m = array.GetLength(1);
    for (int j = 0; j < m; j+=2)
    {
        for (int a = 0; a < n; a++)
        {
            for (int i = 0; i < n-a-1; i++)
            {
                if (array[i, j] > array[i+1, j])
                {
                    int newarray = array[i, j];
                    array[i, j] = array[i+1, j];
                    array[i+1, j] = newarray;
                }
            }
        }
    }
}

void PrintArray(int[,] array)
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

