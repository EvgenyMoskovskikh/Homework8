// // // // Напишите программу, которая заполнит спирально массив 4 на 4.

int[,] matrix = SpiralArray();
int[,] SpiralArray()
{
    int[,] array = new int[4, 4];

    int x = 1;
    for (int k = 0; k < 2; k++)
    {
        int i, j;
        // проходим по верхней строке витка спирали слева направо
        i = k;
        for (j = k; j < 4 - k; j++)
            array[i, j] = x++;

        // проходим по правому столбцу витка спирали сверху вниз
        j = (4 - 1) - k;
        for (i = k; i < 4 - k; i++)
            array[i, j] = x++;


        // проходим по нижней строке витка спирали справо налево
        i = (4 - 1) - k;
        for (j = (4 - 1) - k - 1; j > k - 1; j--)
            array[i, j] = x++;

        // проходим по левому столбцу витка спирали снизу вверх
        j = k;
        for (i = (4 - 1) - k - 1; i > k; i--)
            array[i, j] = x++;

    }
    return array;
}

void VivodMatrix(int[,] array)
{
    int n = array.GetLength(0);
    int m = array.GetLength(1);

    for (int i = 0; i < n; i++)
    {
        for (int j = 0; j < m; j++)
        {
            if (array[i, j] < 10)
                Console.Write($" 0{array[i, j]}  ");
            else
                Console.Write($" {array[i, j]}  ");

        }
        Console.WriteLine();
    }
}

VivodMatrix(matrix);