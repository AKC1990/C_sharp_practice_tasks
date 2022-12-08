// Найти кубы чисел от 1 до N
int[] CreateArray(int N)
{
    return new int[N];
}

int[] FillArray(int[] array)
{
    for (int i = 1; i <= array.Length; i++)
    {
        array[i-1] = i * i * i;
    }
    return array;
}

string PrintArray(int[] array)
{
    string result = "[ ";
    for (int i = 0; i < array.Length; i++)
    {
        result += $"{array[i]} ";
    }
    return result + "]";
}

Console.WriteLine("Enter a number");
int N = Convert.ToInt32(Console.ReadLine());
int[] my_array = CreateArray(N);
FillArray(my_array);
Console.WriteLine(PrintArray(my_array));