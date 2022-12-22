int InputInt(string message)
{
    Console.Write(message);
    return int.Parse(Console.ReadLine());
}

int N = InputInt("Введите число N: ");
int increment = 1;
if (N < 0)
    increment = -1;

for (int i = 1; Math.Abs(i) <= Math.Abs(N); i += increment)
    Console.WriteLine($"Куб из {i} равен {Math.Pow(i,3)}");