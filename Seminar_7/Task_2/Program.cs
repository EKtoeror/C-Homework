Console.WriteLine("Введите строку: ");
int i = Convert.ToInt32(Console.ReadLine() ?? "");
Console.WriteLine("Введите столбец: ");
int j = Convert.ToInt32(Console.ReadLine() ?? "");

/*
int[,] dano = new int [,]
{
    {1,4,7,2},
    {5,9,2,3},
    {8,4,2,4},
};

void FindNumber(int[,] dano)
{
    if (i > dano.GetLength(0) || j > dano.GetLength(1))
    {
        Console.WriteLine($"Числа в позиции [{i},{j}] в массиве нет");
    }
}
FindNumber(dano);
*/

void MakeMassive(int [,]array)
{
    for (int m = 0; m < array.GetLength(0); m++)
    {
        for (int n = 0; n < array.GetLength(1); n++)
        {
            array [m,n]=new Random().Next(-20,20);
            Console.Write($"{array[m,n]} ");            
        }
        Console.WriteLine();
    }
    if (i>array.GetLength(0) || j>array.GetLength(1))
        {
            Console.WriteLine($"Числа в позиции [{i},{j}] в массиве нет");
        }
}
int [,]array=new int[3,4];
MakeMassive(array);