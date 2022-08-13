// Напишите программу, которая на вход принимает значение элемента в двумерном массиве, 
// и возвращает позицию этого элемента или же указание, что такого элемента нет.

/// Метод описывающий заполенение двумерного массива
int [,] GetMatrix(int rows, int columns)
{
    int [,] matrix = new int[rows, columns];
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i,j] = new Random().Next(10, 100); 
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
}

// Объявляяем, заполняем и печатаем массив
int [,] resultMatrix = GetMatrix(8, 8);
System.Console.WriteLine("\nМассив чисел:\n");
PrintMatrix(resultMatrix);

// Алгоритм поиска и вывода позиции элемента массива по его значению
bool checkValue = false;
System.Console.WriteLine("\nЧтобы найти позицию элемента массива, введите его значение:\n");
int userNumber = Int32.Parse(Console.ReadLine());

for (int i = 0; i < resultMatrix.GetLength(0); i++)
    {
        for (int j = 0; j < resultMatrix.GetLength(1); j++)
        {
            if (userNumber == resultMatrix[i,j])
            {
                Console.WriteLine($"\nПозиция элемента массива со значением {userNumber}: [{i},{j}]\n");
                checkValue = true;
            }
        }
    }

if (checkValue == false)
{
    Console.WriteLine($"\nЭлемента массива со значением {userNumber} не существует\n");
}