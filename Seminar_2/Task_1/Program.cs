Console.WriteLine("Введите трехзначное число : ");
string n = Console.ReadLine() ?? "";

int number = Convert.ToInt32(n);

number = Math.Abs(number);

void ShowSecondDigit(int number)
{
    if ((number >= 99) && (number <= 1000))
    {
        int number0 = (number / 10) % 10;
        Console.WriteLine($"Вторая цыфра числа {number} - {number0}");
    }
    else
    {
        Console.WriteLine("Ввели неверное число");
    }
}


ShowSecondDigit(number);
