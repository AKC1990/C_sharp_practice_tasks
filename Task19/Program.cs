// Определить номер четверти плоскости, в которой находится точка с координатами Х и У, причем X ≠ 0 и Y ≠ 0

int x = -10;
int y = 18;

if (x != 0 && y != 0)
{
    if (x > 0 && y > 0)
    {
        Console.WriteLine("The second quarter");
    }
    else if (x < 0 && y > 0)
    {
        Console.WriteLine("The first quarter");
    }
    else if (x > 0 && y < 0)
    {
        Console.WriteLine("The third quarter");
    }
    else
    {
        Console.WriteLine("The fourth quarter");
    }
}
else 
{
    Console.WriteLine("x or y can`t be 0");
}