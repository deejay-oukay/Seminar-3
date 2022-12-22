int InputInt(string message)
{
    Console.Write(message);
    return int.Parse(Console.ReadLine());
}

int number = 0;
while (
    (Math.Abs(number) < 10000) || (Math.Abs(number) > 99999)
)
    number = InputInt("Введите пятизначное число: ");

string numberString = Convert.ToString(number);
int minus = 0;
if (number < 0)
    minus = 1;
if ((numberString[0+minus] == numberString[4+minus]) && (numberString[1+minus] == numberString[3+minus]))
    Console.WriteLine("Это полиндром");
else
    Console.WriteLine("Это НЕ полиндром");
