Console.Write("Введите число А: ");
int a = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите число B: ");
int b = Convert.ToInt32(Console.ReadLine());

b = Math.Abs(b);

int result=a;
for (int i = 1; i < b; i++)
{
    result = a * result;
}
Console.Write(result);