// Даны два числа. Показать большее и меньшее число
//Требуется написать код для определения наибольшего и наименьшего целых чисел.

int a = 2;
int b = 5;

if (a != b)
{
    if (a > b)
    {
        Console.Write("max = ");
        Console.WriteLine(a);
        Console.Write("min = ");
        Console.WriteLine(b);
    }
    else
    {
        Console.Write("max = ");
        Console.WriteLine(b);
        Console.Write("min = ");
        Console.WriteLine(a);
    }
}
else
{
    Console.Write("Equal numbers. Please, enter another numbers");
}
