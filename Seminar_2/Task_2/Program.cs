Console.WriteLine("Введите число: ");
string n = Console.ReadLine() ?? "";

int number = Convert.ToInt32(n);

number = Math.Abs(number);

void ShowThirdDigit(int number)
{
    if (number > 99)
    {
        //int number0 = number % 10;
        //Console.WriteLine($"Третья цыфра числа {number} - {number0}");
        string number0 = Convert.ToString(number);
        Console.WriteLine($"Третья цыфра числа {number} - {number0[2]}");
    }
    else
    {
        Console.WriteLine("Третьей цыфры нет");
    }
}

ShowThirdDigit(number);