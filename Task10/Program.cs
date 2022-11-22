// Показать вторую цифру трёхзначного числа

int number = 264;
if (number >= 100 && number <= 999)
{
    Console.WriteLine(number / 10 % 10);
}
else
{
    Console.WriteLine("Error. Incorrect number");
}
