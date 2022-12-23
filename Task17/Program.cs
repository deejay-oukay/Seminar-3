int InputInt(string message)
{
    Console.Write(message);
    return int.Parse(Console.ReadLine());
}

void Output(string message)
{
    Console.WriteLine(message);
}

int x = InputInt("Введите значение числа X: ");
int y = InputInt("Введите значение числа Y: ");

if ((x > 0) && (y > 0))
    Output("1-ая четверть");
else if ((x < 0) && (y > 0))
    Output("2-ая четверть");
else if ((x < 0) && (y < 0))
    Output("3-ая четверть");
else if ((x > 0) && (y < 0))
    Output("4-ая четверть");
else
    Output("X и Y не должны быть равны 0");
