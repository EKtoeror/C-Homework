Console.WriteLine("Введите число");
string n = Console.ReadLine()?? "";

int n1 = Convert.ToInt32(n);

if (n1 % 2 >0)
    Console.WriteLine($"Число {n1} нечетное");
else
    Console.WriteLine($"Число {n1} четное");
