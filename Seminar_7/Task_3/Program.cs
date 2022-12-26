
void MakeMassive(int [,]dano)
{
    for (int i = 0; i < dano.GetLength(0); i++)
    {
        for (int j = 0; j < dano.GetLength(1); j++)
        {
            dano[i,j]=new Random().Next(-20,20);
            Console.Write($"{dano[i,j]} ");            
        }
        Console.WriteLine();
    }
}

void ArithMean(int [,]dano)
{
    for (int j = 0; j < dano.GetLength(1); j++)
    {
        double result=0;
        for (int i = 0; i < dano.GetLength(0); i++)
        {
            result=result+dano[i,j];
        }
        Console.WriteLine($"Среднее арифметическое столбца {j+1} = {result/3}");
    }
}

int [,]dano=new int [3,4];
MakeMassive(dano);
ArithMean(dano);


/*
int[,] dano = new int [,]
{
    {1,4,7,2},
    {5,9,2,3},
    {8,4,2,4},
};

void ArithMean(int [,]dano)
{
    for (int j = 0; j < dano.GetLength(1); j++)
    {
        double result=0;
        for (int i = 0; i < dano.GetLength(0); i++)
        {
            result=result+dano[i,j];
        }
        Console.WriteLine($"Среднее арифметическое столбца {j+1} = {result/3}");
    }
}
ArithMean(dano);
*/


