int InputInt(string message)
{
    Console.Write(message);
    return int.Parse(Console.ReadLine());
}

int x = InputInt("Введите значение числа X: ");
int y = InputInt("Введите значение числа Y: ");

if ((x > 0) && (y > 0))
    Console.WriteLine("1-ая четверть");
else if ((x < 0) && (y > 0))
    Console.WriteLine("2-ая четверть");
else if ((x < 0) && (y < 0))
    Console.WriteLine("3-ая четверть");
else if ((x > 0) && (y < 0))
    Console.WriteLine("4-ая четверть");
else
    Console.WriteLine("X и Y не должны быть равны 0");
