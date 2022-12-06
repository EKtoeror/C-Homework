Console.WriteLine("Введите 3 числа");
string number1 = Console.ReadLine() ?? "";
string number2 = Console.ReadLine() ?? "";
string number3 = Console.ReadLine() ?? "";

int n1 = Convert.ToInt32(number1);
int n2 = Convert.ToInt32(number2);
int n3 = Convert.ToInt32(number3);

int max = n1;

if (n1 > n2)
    max = n1;
else
    if (n2 > n3)
    max = n2;
    else
    max = n3;
    Console.WriteLine($"Наибольшее число {max}");