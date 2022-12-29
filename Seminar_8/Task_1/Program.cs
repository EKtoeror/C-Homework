
Console.WriteLine("Введите кол-во строк: ");
int i =Convert.ToInt32(Console.ReadLine()??"");
Console.WriteLine("Введите кол-во столбцов: ");
int j =Convert.ToInt32(Console.ReadLine()??"");

void InitMatrix(int [,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i,j]=new Random().Next(1,10);
        }
    }
}

void Selection(int [,]array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            for (int k = 0; k < array.GetLength(1)-1; k++)
            {
                if (array[i,k]<array[i,k+1])
                {
                    int temp=array[i,k+1];
                    array[i,k+1]=array[i,k];
                    array[i,k]=temp;                  
                }                
            }   
        } 
    }           
}

void PrintMatrix(int [,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"{array[i,j]} ");
        }
        Console.WriteLine();
    }
}

int [,]array=new int[i,j];
InitMatrix(array);
PrintMatrix(array);
Selection(array);
Console.WriteLine();
PrintMatrix(array);