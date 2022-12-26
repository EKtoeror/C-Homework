
void MakeMassive(double[,]array)
{
    for (int m = 0; m < array.GetLength(0); m++)
{
    for (int n = 0; n < array.GetLength(1); n++)
    {
        array[m,n]=new Random().Next(-10,10);
        Console.Write($"{array[m,n]} ");
    }
    Console.WriteLine();
}
}


double [,]array=new double [3,4];
MakeMassive(array);
