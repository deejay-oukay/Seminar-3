int InputInt(string message)
{
    Console.Write(message);
    return int.Parse(Console.ReadLine());
}

void Square(int number)
{
    Console.WriteLine($"Квадрат из {number} равен {Math.Pow(number,2)}");
}

int N = InputInt("Введите число N: ");
//если N равно нулю, то цикл для него работать не будет
if (N == 0)
{
    Square(1);
    Square(0);
}
else
{
    int increment = 1;
    if (N < 0)
        increment = -1;

    for (int i = 1; Math.Abs(i) <= Math.Abs(N); i += increment)
        Square(i);
}
