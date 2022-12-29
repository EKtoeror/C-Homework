Console.WriteLine("Введите кол-во строк: ");
int i =Convert.ToInt32(Console.ReadLine()??"");
Console.WriteLine("Введите кол-во столбцов: ");
int j =Convert.ToInt32(Console.ReadLine()??"");

int [,]array=new int[i,j];
InitMatrix(array);
minRowSum(array);

void InitMatrix(int [,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i,j]=new Random().Next(1,10);
            Console.Write($"{array[i,j]} ");
        }
        Console.WriteLine();    
    }    
}
void minRowSum (int [,]array)
{    
    int []sums=new int[array.GetLength(0)];
    for (int i = 0; i < array.GetLength(0); i++)
    {
        //int []sums=new int[array.GetLength(0)];
        int result=0;    
        for (int j = 0; j < array.GetLength(1); j++)
        {
            result=result+array[i,j];
            //Console.Write($"{result} ");
        }
        sums[i]=result;
        Console.Write($"{sums[i]} ");        
    }
    Console.WriteLine();
    int minSum=sums[0];
    int minRow=1;
    for (int i = 0; i < array.GetLength(0); i++)
    {
        //int minRow;
        if (sums[i]<minSum)
        {
            minSum=sums[i];
            minRow=i+1;    
        }
    }
    Console.WriteLine($"Минимальная сумма в строке : {minRow}");        
}

//int [,]array=new int[i,j];
//InitMatrix(array);
//minRowSum(array);
