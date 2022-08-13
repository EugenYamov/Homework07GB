// Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.

/// Метод описывающий заполенение двумерного массива
int [,] GetMatrix(int rows, int columns)
{
    int [,] matrix = new int[rows, columns];
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i,j] = new Random().Next(10); 
        }
    }
    return matrix;
}

/// Метод описывающий вывод массива на экран
void PrintMatrix(int [,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write(matrix[i,j] + "\t");
        }
        System.Console.WriteLine();
    }
    System.Console.WriteLine();
}

// Объявляяем, заполняем и печатаем массив
int [,] resultMatrix = GetMatrix(3, 5);
System.Console.WriteLine("\nМассив чисел:\n");
PrintMatrix(resultMatrix);


// Алгоритм для нахождения среднего арифмитического в каждом столбце матрицы
for (int j = 0; j < resultMatrix.GetLength(1); j++)
{
    float averageValue = 0;
    for (int i = 0; i < resultMatrix.GetLength(0); i++)
    {
        averageValue += resultMatrix[i,j];
    }
    System.Console.WriteLine($"Среднее арифметическое столбца №{j+1} = {Math.Round(averageValue / resultMatrix.GetLength(0),2)}");
}
System.Console.WriteLine();
