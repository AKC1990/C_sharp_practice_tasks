// Дано число. Проверить кратно ли оно 7 и 23

int number = 161;
if (number % 7 == 0)
{
    if (number % 23 == 0)
    {
        Console.Write(number);
        Console.Write(" is multiply 7 and 23");
    }
    else
    {
        Console.Write(number);
        Console.Write(" is multiply 7, but isn't multiply 23");
    }
}
else if  (number % 23 == 0)
{
    Console.Write(number);
    Console.Write(" is multiply 23, but isn't multiply 7");
}
else
{
    Console.Write(number);
    Console.Write(" is isn't multiply 7 and 23");
}