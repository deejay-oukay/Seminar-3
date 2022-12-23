int InputInt(string message)
{
    Console.Write(message);
    return int.Parse(Console.ReadLine());
}

int
    x1 = InputInt("Введите координату X для точки 1: "),
    y1 = InputInt("Введите координату Y для точки 1: "),
    x2 = InputInt("Введите координату X для точки 2: "),
    y2 = InputInt("Введите координату Y для точки 2: ")
;

Console.WriteLine("Расстояние между двумя точками в 2D-пространстве = "+Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2)));