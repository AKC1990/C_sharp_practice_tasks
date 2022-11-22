// Дано число из отрезка [10, 99]. Показать наибольшую цифру числа

int number = 35;

if (number >= 10 && number <= 99)

{
    int a = number / 10;
    int b = number % 10;
    
    if (a > b)
    {
        Console.WriteLine(a);
    }

    else
    {
        Console.WriteLine(b);
    }
}
else
{
    Console.WriteLine("Error. Incorrect number");
}

