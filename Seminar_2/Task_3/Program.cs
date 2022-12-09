Console.Write("Введи цифру, обозначающую день недели: ");
string day = Console.ReadLine() ?? "";
int dayZ = Convert.ToInt32(day);

void CheckingTheDayOfTheWeek(int dayZ)
{
    if (dayZ == 6 && dayZ == 7)
    {
        Console.WriteLine("Это - выходной");
    }
    else if (dayZ < 1 && dayZ > 7)
    {
        Console.WriteLine("Такого дня недели нет");
    }
    else Console.WriteLine("Это - не выходной");
}

CheckingTheDayOfTheWeek(dayZ);