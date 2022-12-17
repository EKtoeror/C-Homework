void Quantity(int [] array)
{
    Console.Write("[");

    int quantity=0;
    for (int i = 0; i < array.Length; i++)
    {
        array[i]=new Random().Next(100,999);
        Console.Write(array[i]);
        if (i<array.Length-1)
        {
            Console.Write(",");
        }
        if (array[i]%2==0)
        {
            quantity++;
        }
    }
    Console.Write("]");
    Console.WriteLine();
    Console.WriteLine($"Кол-во четных чисел в массиве = {quantity}");
}
int []array=new int [4];
Quantity(array);
