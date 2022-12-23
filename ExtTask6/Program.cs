int InputInt(string message)
{
    Console.Write(message);
    return int.Parse(Console.ReadLine());
}

bool IsCorrect(int number)
{
    if (number > 1) //чтобы было, что сортировать, должно быть хотя бы 2 элемента в массиве
        return true;
    else
        return false;
}

int Rand(int start, int finish)
{
    return new Random().Next(start,finish+1);
}

void PrintArray(int[] array)
{
    //?есть ли способ работать не с локальным, а с глобальным массивом при котором методы можно было бы описывать до основного кода?
    Console.Write("Упорядоченные элементы массива: ");
    string comma = "";

    foreach (int item in array)
    {
        if ((item >= -20) && (item <= 20))
        {
            Console.Write($"{comma}{item}");
            if (comma == "") //можно было бы присвоение делать при каждом проходе без условия, но частое чтение и однократная запись сработают быстрее, чем многократная запись без чтения
                comma = ", ";
        }
    }
}

int n = 0;
while (!IsCorrect(n = InputInt("Укажите число элементов для массива: ")))
    Console.Write("Маловато будет... ");

int[] array = new int[n];

for (int i = 0; i < n; i++)
    array[i] = Rand(-50, 50);

Array.Sort(array);

PrintArray(array);