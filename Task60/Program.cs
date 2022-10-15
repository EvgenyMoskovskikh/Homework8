// Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
// Массив размером 2 x 2 x 2

Console.Write("Введите значение a: ");
int a = int.Parse(Console.ReadLine()!);
Console.Write("Введите значение b: ");
int b = int.Parse(Console.ReadLine()!);
Console.Write("Введите значение c: ");
int c = int.Parse(Console.ReadLine()!);

int[,,] array = new int[a, b, c];
GetArray(array);
NewGetArray(array);

void NewGetArray(int[,,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"A({i}) B({j}) ");
            for (int k = 0; k < array.GetLength(2); k++)
            {
                Console.Write($"C({k})={array[i, j, k]}; ");
            }
            Console.WriteLine();
        }
        Console.WriteLine();
    }
}

void GetArray(int[,,] array)
{
    int[] temp = new int[array.GetLength(0) * array.GetLength(1) * array.GetLength(2)];
    int number;
    for (int i = 0; i < temp.GetLength(0); i++)
    {
        temp[i] = new Random().Next(10, 100);
        number = temp[i];
        if (i >= 1)
        {
            for (int j = 0; j < i; j++)
            {
                while (temp[i] == temp[j])
                {
                    temp[i] = new Random().Next(10, 100);
                    j = 0;
                    number = temp[i];
                }
                number = temp[i];
            }
        }
    }
    int count = 0;
    for (int a = 0; a < array.GetLength(0); a++)
    {
        for (int b = 0; b < array.GetLength(1); b++)
        {
            for (int c = 0; c < array.GetLength(2); c++)
            {
                array[a, b, c] = temp[count];
                count++;
            }
        }
    }
}
