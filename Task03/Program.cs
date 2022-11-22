// По заданному номеру дня недели вывести его название

int day_number = 5;
if (1 <= day_number && day_number <= 7)
{
    if (day_number == 1)
    {
        Console.Write("Monday");
    }
    if (day_number == 2)
    {
        Console.Write("Tuesday");
    }
    if (day_number == 3)
    {
        Console.Write("Wednesday");
    }
    if (day_number == 4)
    {
        Console.Write("Thursday");
    }
    if (day_number == 5)
    {
        Console.Write("Friday");
    }
    if (day_number == 6)
    {
        Console.Write("Saturday");
    }
    if (day_number == 7)
    {
        Console.Write("Sunday");
    }
}  
else
{
    Console.Write("Error. day_number can be in the range from 1 to 7");
}