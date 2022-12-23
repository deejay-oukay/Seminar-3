int InputInt(string message)
{
    Console.Write(message);
    return int.Parse(Console.ReadLine());
}

bool IsCorrect(int number)
{
    if ((number > 0) && (number < 8))
        return true;
    else
        return false;
}

string[] days =
{
    "понедельник",
    "вторник",
    "среда",
    "четверг",
    "пятница",
    "суббота",
    "восскресенье"
};

int dayNumber;

while (!IsCorrect(dayNumber = InputInt("Введите номер дня недели: ")))
    Console.Write("Некорректный номер дня недели. ");

Console.Write($"Это {days[dayNumber-1]}. ");
Console.Write("До воскресенья осталось дней: "+(7-dayNumber));
