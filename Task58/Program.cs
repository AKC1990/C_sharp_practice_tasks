// Написать программу, которая в двумерном массиве заменяет строки на столбцы или сообщить, что это невозможно (в случае, если матрица не квадратная).

int[,] CreateMatrix(int row, int col)
{
    return new int[row, col];
}

bool CheckCountOfRows(int rows, int columns)
{
    return rows == columns;
}

int[,] FillMatrix(int[,] matrix)
{
    int min = 1;
    int max = 50;
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = new Random().Next(min, max);
        }
    }
    return matrix;
}

string PrintMatrix(int[,] matrix)
{
    string result = string.Empty;
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            result += $"{matrix[i, j],3}";
        }
        result += "\n";
    }
    return result;
}

int[,] ReplaceElementsOfMatrix(int[,] matrix)
{
    int[,] newMatrix = new int[matrix.GetLength(0), matrix.GetLength(1)];
    for (int i = 0; i < newMatrix.GetLength(0); i++)
    {
        for (int j = 0; j < newMatrix.GetLength(1); j++)
        {
            newMatrix[i, j] = matrix[j, i];
        }
    }
    return newMatrix;
}

int rows = 4;
int columns = 5;
if (CheckCountOfRows(rows, columns))
{
    int[,] myMatrix = CreateMatrix(rows, columns);
    Console.WriteLine(PrintMatrix(FillMatrix(myMatrix)));
    Console.WriteLine();
    Console.WriteLine(PrintMatrix(ReplaceElementsOfMatrix(myMatrix)));
}
else System.Console.WriteLine("incorrect count of rows");