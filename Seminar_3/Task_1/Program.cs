Console.WriteLine("Введите 5ти значное число: ");

int number = Convert.ToInt32(Console.ReadLine());

if (number>9999&&number<99999)
{
    void Check(int number)
    {
        string n=Convert.ToString(number);
        int dig1= Convert.ToInt32(n[0]);
        int dig2= Convert.ToInt32(n[1]);
        int dig4= Convert.ToInt32(n[3]);
        int dig5= Convert.ToInt32(n[4]);
        if (dig1==dig5&&dig2==dig4)
        {
            Console.WriteLine($"Число {number} является полиморфом");
        }
        else
        {
            Console.WriteLine($"Число {number} не является полиморфом");
        }
    }
    Check(number);
}

else
{
    {
        Console.WriteLine("Введено неверное число");
    }
}   

        