// Программа проверяет пятизначное число на палиндромом.

//Метод, получающий на вход число и преобразующий его в массив
int [] ConvertIntToArray (int number)
{
    string str = number.ToString();
    int[] result = new int[str.Length];
    for( int i=0; i < str.Length; i++)
    {
        result[i] = int.Parse(str[i].ToString());
    }
    return result;
}

//Метод, печатающий массив
void PrintArray (int[] array)
{
    for ( int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i]);
    }
    Console.WriteLine();
}

//Метод, "переворачивающий" массив
int[] ReverseArray (int[] array)
{
    int [] reversed = new int [array.Length];
    for ( int i = 0; i < array.Length; i++)
    {
        reversed[i] = array[array.Length - 1 - i];
    }
    return reversed;
}

//Мeтод, преобразующий массив в число
int ConvertArrayToInt(int[] array)
{
    int finalScore = 0;
    for (int i = 0; i < array.Length; i++)
    {
        finalScore += array[i] * Convert.ToInt32(Math.Pow(10, array.Length-i-1));
    }
    return finalScore;
}

bool CheckToPolyndrom(int numberA, int numberB)
{
    return numberA == numberB;
}

Console.Write("Enter any number: ");
int number = Convert.ToInt32(Console.ReadLine());
ConvertIntToArray(number);
PrintArray(ConvertIntToArray(number));
PrintArray(ReverseArray(ConvertIntToArray(number)));
int reversedNumber = ConvertArrayToInt(ReverseArray(ConvertIntToArray(number)));
Console.WriteLine(CheckToPolyndrom(number, reversedNumber));
