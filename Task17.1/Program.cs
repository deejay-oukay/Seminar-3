int InputInt(string message)
{
    Console.Write(message);
    return int.Parse(Console.ReadLine());
}

void Output(string message)
{
    Console.WriteLine(message);
}

string QuarterInfo(int number)
{
    switch (number)
    {
        case 1:
            return "x>0,y>0";
        case 2:
            return "x<0,y>0";
        case 3:
            return "x<0,y<0";
        case 4:
            return "x>0,y<0";
        default:
            return "Что-то пошло не так. ";
    }
}

Output(QuarterInfo(InputInt("Введите номер четверти: ")));