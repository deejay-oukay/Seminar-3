int InputInt(string message)
{
    Console.Write(message);
    return int.Parse(Console.ReadLine());
}

bool IsCorrectMonth(int number)
{
    if ((number > 0) && (number < 13))
        return true;
    else
        return false;
}

bool IsCorrectDay(int day, int month)
{
    DateTime date = new DateTime();
    if ((day > 0) && (day <= System.DateTime.DaysInMonth(date.Year, month)))
        return true;
    else
        return false;
}

string[] months = {"Январь","Феваряль","Март","Апрель","Май","Июнь","Июль","Август","Сентябрь","Октябрь","Ноябрь","Декабрь"};

int monthNumber = 0;
int dayNumber = 0;

while (!IsCorrectMonth(monthNumber = InputInt("Укажите номер месяца: ")))
    Console.Write("Нет такого месяца... ");

DateTime date = new DateTime();
Console.WriteLine($"Название месяца: {months[monthNumber-1]}\nКоличество дней в месяце: {System.DateTime.DaysInMonth(date.Year, monthNumber)}");

while (!IsCorrectDay(dayNumber = InputInt("Укажите номер дня в месяце: "),monthNumber))
    Console.Write("Нет такого дня в месяце... ");

Console.WriteLine($"До конца месяца осталось дней: {System.DateTime.DaysInMonth(date.Year, monthNumber)-dayNumber}");

Console.WriteLine("Следующий месяц: "+(monthNumber == 12 ? months[0]+". С наступающим! (-: так и появляются пасхалочки :-)" : months[monthNumber]));