// Удалить вторую цифру трёхзначного числа

int number = 123;

int a = number / 100;
int b = number % 10;
 
if (number >= 100 && number <= 999)
{
    Console.Write(a * 10 + b);
}
else
{
    Console.WriteLine("Error. Incorrect number");
}
