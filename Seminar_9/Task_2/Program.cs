Console.Write("Введите M: ");
int m=Convert.ToInt32(Console.ReadLine()??"");
Console.Write("Введите N: ");
int n=Convert.ToInt32(Console.ReadLine()??"");

int result=0;
for (int i = 0; i <=n; i++)
{
    result=(m+n)*(n-m+1)/2;
}
Console.WriteLine($"Сумма натуральных чисел от {m} до {n} = {result}");

