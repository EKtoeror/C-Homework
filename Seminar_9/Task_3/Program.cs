Console.Write("Введите M: ");
int m = Convert.ToInt32(Console.ReadLine() ?? "");
Console.Write("Введите N: ");
int n = Convert.ToInt32(Console.ReadLine() ?? "");
/*
int Akkerman(int m,int n)
{
    int result=0;
    for (int i = 0; i <=m; i++)
    {
        if (m==0)
        {
            return result=n+1; 
        }
        else if (m>0 && n==0)
        {
            return result=Akkerman(m-1,1);
        }
        else if (m>0&&n>0)
            {
                return result=Akkerman(m-1,Akkerman(m,n-1));
            }
        }
    }
    Console.WriteLine(result);

Akkerman(m,n);
*/
int Akkerman(int m, int n)
{
    if (m == 0)
    {
        return n + 1;
    }
    else if (m != 0 && n == 0)
    {
        return Akkerman(m - 1, 1);
    }
    else  if (m > 0 && n > 0)
    {
        return Akkerman(m - 1, Akkerman(m, n - 1));
    }
    return Akkerman(m,n);
}
for (int i = 0; i < m; i++)
{
    for (int j = 0; j < n; j++)
    {
        Akkerman(i, j);
    }
}
Console.WriteLine(Akkerman(m, n));
