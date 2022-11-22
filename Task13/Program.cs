//  Выяснить, кратно ли число заданному, если нет, вывести остаток

int number1 = 22;
int number2 = 5;

if (number1 % number2 != 0)
{
    Console.Write(number1 + " mod " + number2 + " = " + (number1 % number2));
}
else
{
    Console.Write(number1 + " is multiply " + number2);
}
