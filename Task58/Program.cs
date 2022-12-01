// Написать программу, которая в двумерном массиве заменяет строки на столбцы или сообщить, что это невозможно (в случае, если матрица не квадратная).

int[,] CreateMatrix(int row, int col)
{
    return new int [row, col];
}

int[,] FillMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i,j] = new Random().Next(1, 50);
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
            Console.Write($"{matrix[i, j], 3}");
        }
    Console.WriteLine();
    }
}

int[,] ReplaceElementsOfMatrix(int[,] matrix)
{
    int[,] newMatrix = new int[matrix.GetLength(0), matrix.GetLength(1)];
    for (int i = 0; i < newMatrix.GetLength(0); i++)
    {
        for (int j = 0; j < newMatrix.GetLength(1); j++)
        {
            newMatrix[i,j] = matrix[j, i];
        }
    }
    return newMatrix;
}

int rows = 6;
int columns = 6;
int [,] myMatrix = CreateMatrix(rows, columns);
PrintMatrix(FillMatrix(myMatrix));
Console.WriteLine();
PrintMatrix(ReplaceElementsOfMatrix(myMatrix));

