int InputInt(string message)
{
    Console.Write(message);
    return int.Parse(Console.ReadLine());
}

int N = InputInt("Введите число N: ");
if (N == 0)
    //если N равно нулю, то цикл для него работать не будет
    Console.WriteLine("Куб из 1 равен 1\nКуб из 0 равен 0");
else
{
    int increment = 1;
    if (N < 0)
        increment = -1;

    for (int i = 1; Math.Abs(i) <= Math.Abs(N); i += increment)
        Console.WriteLine($"Куб из {i} равен {Math.Pow(i,3)}");
}
