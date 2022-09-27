// Задача 62.
// Напишите программу, которая заполнит спирально массив 4 на 4.
// Например, на выходе получается вот такой массив:
// 01 02 03 04
// 12 13 14 05
// 11 16 15 06
// 10 09 08 07

// Console.Clear();
Console.WriteLine("\t Задача №62");
int[,] matrix = new int[5, 5];
Spiral(0, 0, Numbers(matrix), matrix);

Console.WriteLine("");
PrintArray(matrix);

int[] Numbers(int[,] array) // cba[i].Text = (i + 1).ToString("D2");
{
    int[] numbers = new int[array.GetLength(0) * array.GetLength(1)];
    for (int i = 0; i < numbers.Length; i++)
    {
        numbers[i] = i;
    }
    return numbers;
}

void Spiral(int row, int col, int[] array, int[,] array2D)
{
    int i = 0;
    int arrayCurrentIndex = 0;

    while (arrayCurrentIndex < array.Length)
    {

        while (col < array2D.GetLength(1) - i)
        {
            array2D[row, col] = array[arrayCurrentIndex];
            arrayCurrentIndex++;
            col++;
        }
        col--; // возвращаю счетчик
        row++;
        while (row < array2D.GetLength(0) - i)
        {
            array2D[row, col] = array[arrayCurrentIndex];
            row++;
            arrayCurrentIndex++;
        }
        col--;
        row--; // возвращаю счетчик
        while (col >= 0 + i)
        {
            array2D[row, col] = array[arrayCurrentIndex];
            col--;
            arrayCurrentIndex++;

        }
        i++;
        col++; // возвращаю счетчик
        row--;
        while (row >= 0 + i)
        {
            array2D[row, col] = array[arrayCurrentIndex];
            row--;
            arrayCurrentIndex++;

        }
        col++;
        row++; // возвращаю счетчик

    }
}



void PrintArray(int[,] array)
{
    Console.WriteLine("");
    for (int i = 0; i < array.GetLength(0); i++)
    {
        Console.Write("[ ");
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"{array[i, j].ToString("00")}\t");
        }
        Console.SetCursorPosition(Console.CursorLeft - 6, Console.CursorTop);
        Console.WriteLine(" ]");
    }
    Console.WriteLine("");
}
