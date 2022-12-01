// Показать таблицу квадратов чисел от 1 до N 
// *Задачу решил усложнить и вывести матрицу

// Метод, заполняющий массив
int[,] FillHeadlightsMatrix (int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        matrix[i,0] = i;
    }
    
    for (int j = 1; j < matrix.GetLength(1); j++)
    {
        matrix[0, j] = j;
    }
    
    for (int i = 1; i < matrix.GetLength(0); i++)
    {
        for (int j = 1; j < matrix.GetLength(1); j++)
        {
            matrix[i,j] = Convert.ToInt32(Math.Pow(matrix[i,0], j));
        }
    }
    return matrix;
}

//Метод, печатающий массив
void PrintMatrix(int[,] matrix)
{
    
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write($"{matrix[i,j], 10}");
        }
    Console.WriteLine();
    }
}

int N = 11;
int[,] matrix = new int[N, 10];
int[,] myMatrix = FillHeadlightsMatrix(matrix);
PrintMatrix(FillHeadlightsMatrix(myMatrix));
