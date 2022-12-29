// провека
int[,] first = new int [,]
{
    {2,4},
    {3,2},
};
int[,] second = new int [,]
{
    {3,4},
    {3,3},
};

//int [,]first=new int[2,2];
//int [,]second=new int[2,2];
int [,]third=new int[first.GetLength(0),second.GetLength(1)];
//InitTwoMatrix(first,second);
PrintFirst(first);
Console.WriteLine();
PrintSecond(second);
Console.WriteLine();
CreateThird(third);

void InitTwoMatrix(int [,] first,int[,]second)
{
    for (int i = 0; i < first.GetLength(0); i++)
    {
        for (int j = 0; j < first.GetLength(1); j++)
        {
            first[i,j]=new Random().Next(1,10);
            second[i,j]=new Random().Next(1,10);
        }
    }
}
void PrintFirst(int[,]first)
{
    for (int i = 0; i < first.GetLength(0); i++)
    {
        for (int j = 0; j < first.GetLength(1); j++)
        {
            Console.Write($"{first[i,j]} ");
        }
        Console.WriteLine();   
    }
}
void PrintSecond(int[,]second)
{
    for (int i = 0; i < second.GetLength(0); i++)
    {
        for (int j = 0; j < second.GetLength(1); j++)
        {
            Console.Write($"{second[i,j]} ");
        }
        Console.WriteLine();   
    }
}
void CreateThird(int [,]third)
{
    for (int i = 0; i < first.GetLength(0); i++)
    {
        for (int j = 0; j < second.GetLength(1); j++)
        {
            third[i,j]=0;
            for (int k = 0; k < second.GetLength(0); k++)
                    {
                        third[i,j] += first[i,k] * second[k,j];
                    }
            Console.Write($"{third[i,j]} ");
        }
        Console.WriteLine();   
    }
}

