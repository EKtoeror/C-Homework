Console.WriteLine("Введите число");
string n = Console.ReadLine()?? "";

int n1 = Convert.ToInt32(n);

n1 = Math.Abs(n1);

for (int i = 2; i <= n1; i++)
{
    if (i % 2 ==0)
    
        Console.Write(i+" ");
    
}
