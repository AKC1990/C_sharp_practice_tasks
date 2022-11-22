// Показать последнюю цифру трёхзначного числа

int number = 526;
if (number >= 100 && number <= 999)
{
    Console.WriteLine(number % 10);
}
else
{
    Console.WriteLine("Error. Incorrect number");
}
