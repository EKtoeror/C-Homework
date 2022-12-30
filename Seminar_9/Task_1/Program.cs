Console.Write("Введите число: ");
int n=Convert.ToInt32(Console.ReadLine()??"");

string PrintNatDig(int n)
{
    
    
    
    if (n == 1)
    {
        return $"{n}";
    }
    else
    {
       return $"{n},{PrintNatDig(n-1)}";
    }
}

for (int i = 1; i <= n; i++)//будет переполнение типа данных
{
    PrintNatDig(i);
}
Console.WriteLine(PrintNatDig(n));
