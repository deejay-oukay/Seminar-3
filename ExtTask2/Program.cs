double ToCM (double inches)
    {
        return inches*2.54; //если речь об английских дюймах: https://ru.wikipedia.org/wiki/Дюйм
    }

double[] diagonals = {10.1, 11.6, 14, 15.6, 17, 19, 24, 27};

for (int i = 0; i < diagonals.Length; i++)
    Console.WriteLine($"{diagonals[i]}'' = {ToCM(diagonals[i]):f2} см.");