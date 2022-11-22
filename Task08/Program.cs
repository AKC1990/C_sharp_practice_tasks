// Показать четные числа от 1 до N

int N = 10;

int i = 1;

while (i <= N)
{   
    if (i % 2 == 0)
    {
        Console.Write(i);
        Console.Write(" ");
    }
    i += 1;
}
