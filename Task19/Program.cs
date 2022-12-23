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
if (number < 0) //если число с минусом не может быть палиндромом (не в курсе),
    minus = 1;  //то просто закомментируем эти две строки :-)
if ((numberString[0+minus] == numberString[4+minus]) && (numberString[1+minus] == numberString[3+minus]))
    Console.WriteLine("Это палиндром");
else
    Console.WriteLine("Это НЕ палиндром");
