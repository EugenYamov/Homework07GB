// Задайте двумерный массив размером m×n, заполненный случайными вещественными числами. (m = 3, n = 4)

/// Метод описывающий заполенение двумерного массива
double[,] GetMatrix(int rows, int columns)
{
    double[,] matrix = new double[rows, columns];
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i,j] = new Random().Next(-100, 101) / 10.0; 
        }
    }
    return matrix;
}

double [,] resultMatrix = GetMatrix(3, 4);

/// Метод описывающий вывод массива на экран
void PrintMatrix(double [,] matrix)
{
    System.Console.WriteLine();
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

PrintMatrix(resultMatrix);