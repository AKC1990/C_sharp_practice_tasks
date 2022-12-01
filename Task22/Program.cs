//Найти расстояние между точками в пространстве 2D/3D

//Метод, создающий массивы с координатами точек

int[] FillDotsCoordinates (int[] array)
{
    for ( int i = 0; i < array.Length; i++) 
    {
        array[i] = Convert.ToInt32(Console.ReadLine());
    }
    return array;
}

double SSecDim (int[] dotA, int[] dotB)
{
    return Math.Round(Math.Sqrt(Math.Pow(dotB[0] - dotA[0], 2) + Math.Pow(dotB[1] - dotA[1], 2)), 2);
}

double SThrdDim (int[] dotA, int[] dotB)
{
    return Math.Round(Math.Sqrt(Math.Pow(dotB[0] - dotA[0], 2) + Math.Pow(dotB[1] - dotA[1], 2) + Math.Pow(dotB[2] - dotA[2], 2)), 2);
}

Console.Write("Enter dimension (2 or 3): ");
int dim = Convert.ToInt32(Console.ReadLine());
int[] dotA = new int[dim];
int[] dotB = new int[dim];
Console.WriteLine("Enter coordinates of the first dot: ");
FillDotsCoordinates(dotA);
Console.WriteLine("Enter coordinates of the second dot: ");
FillDotsCoordinates(dotB);
if (dim == 2) Console.WriteLine($"length = {SSecDim(dotA, dotB)}");
else Console.WriteLine($"length = {SThrdDim(dotA, dotB)}");

