Console.WriteLine("Введите 2 числа");
string number1 = Console.ReadLine() ?? "";
string number2 = Console.ReadLine() ?? "";

int n1 = Convert.ToInt32(number1);
int n2 = Convert.ToInt32(number2);

if (n1>n2)
    Console.WriteLine($"Число {n1} больше {n2}");
else 
    Console.WriteLine($"Число {n2} больше {n1}");