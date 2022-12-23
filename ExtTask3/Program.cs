//видимо, глобальные переменные нужно описывать до методов, в которых они используются (компилятор ругается, если описать после)
int[] numbers = new int[7];
int evenCount = 0;

int InputInt(string message)
{
    Console.Write(message);
    return int.Parse(Console.ReadLine());
}

bool IsCorrect(int number)
{
    number = Math.Abs(number); //учитываем, что число может быть отрицательным
    if ((number > 9) && (number < 100))
        return true;
    else
        return false;
}

void PrintArrayMembers(string option = "all")
{
    switch (option)
    {
        case "even":
            Console.Write("Только чётные числа: ");
            foreach (int item in numbers)
            {
                if ((item % 2) == 0)
                {
                    Console.Write(item+" ");
                    evenCount++;
                }
            }
            Console.Write("\n");
            break;
        default:
            Console.WriteLine("Все элементы массива: ");
            for (int i = 0; i < numbers.Length; i++)
            {
                Console.WriteLine($"{i} => {numbers[i]}"+(i+1 == numbers.Length ? "." : ", "));
            }
            break;
    }
}

for (int i = 0; i < numbers.Length; i++)
{
    while (!IsCorrect(numbers[i] = InputInt($"Введите значение для {i+1}-го двузначного числа ({i}-го элемента массива): ")))
        Console.Write("Это не двузначное число. ");
}

PrintArrayMembers();
PrintArrayMembers("even");
Console.WriteLine(evenCount > 0 ? $"Количество чётных чисел в массиве: {evenCount}" : "В массиве нет чётных чисел");