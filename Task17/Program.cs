// По двум заданным числам проверять является ли одно квадратом другого

int num1 = 10;
int num2 = 100;

if (num1 * num1 == num2)
{
    Console.Write($"{num2} is square of number {num1}");
}
else if (num2 * num2 == num1)
{
    Console.Write($"{num1} is square of number {num2}");
}
else
{
    Console.Write("No");
}
