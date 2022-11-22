// Найти максимальное из трех чисел
int a = 4;
int b = 8;
int c = 6;

if (a > b)
{
    if (a > c)
    {
        Console.Write(a);
    }
    else
    {
        Console.Write(c);
    }
}
else
{
    if (b > c)
    {
        Console.Write(b);
    }
    else
    {
        Console.Write(c);
    }
}
