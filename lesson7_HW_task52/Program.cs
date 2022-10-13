/*Задача 52. Задайте двумерный массив из целых чисел. 
Найдите среднее арифметическое элементов в каждом столбце.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.*/

int[,] generate2DArray(int height, int width, int randomStart, int randomEnd)
{
    int[,] twoDArray = new int[height, width];
    for (int i = 0; i < height; i++)
    {
        for (int j = 0; j < width; j++)
        {
            twoDArray[i, j] = new Random().Next(randomStart, randomEnd + 1);
        }
    }
    return twoDArray;
}

void printColorData(string data)
{
    Console.ForegroundColor = ConsoleColor.Green;
    Console.Write(data);
    Console.ResetColor();
}

void print2DArray(int[,] arrayToPrint)
{
    Console.Write(" \t");
    for (int i = 0; i < arrayToPrint.GetLength(1); i++)
    {
        printColorData(i + "\t");
    }
    Console.WriteLine();
    for (int i = 0; i < arrayToPrint.GetLength(0); i++)
    {
        printColorData(i + "\t");
        for (int j = 0; j < arrayToPrint.GetLength(1); j++)
        {
            Console.Write(arrayToPrint[i, j] + "\t");
        }
        Console.WriteLine();
    }
}

void averageCalumns(int[,] incomingArray)
{
    for (int j = 0; j < incomingArray.GetLength(1); j++)
    {
        double sum = 0;
        double average = 0;
        for (int i = 0; i < incomingArray.GetLength(0); i++)
        {
            sum = sum + incomingArray[i, j];
            average = Math.Round(sum / incomingArray.GetLength(0), 1);
        }
        Console.WriteLine($"Среднее арифметическое элементов {j + 1} столбца равно: {average}");
    }
}

int[,] generateArray = generate2DArray(3, 4, 1, 9);
print2DArray(generateArray);
averageCalumns(generateArray);
