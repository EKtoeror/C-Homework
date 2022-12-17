void SumEvenNumber(int [] array)
{
    Console.Write("[");

    int sum=0;
    for (int i = 0; i < array.Length; i++)
    {
        array[i]=new Random().Next(-20,20);
        Console.Write(array[i]);
        if (i<array.Length-1)
        {
            Console.Write(",");
        }
        if (i%2!=0)
        {
            sum=sum+array[i];
        }
    }
    Console.Write("]");
    Console.WriteLine();
    Console.WriteLine($"Cумму элементов,стоящих на нечётных позициях в массиве = {sum}");
}
int []array=new int [4];
SumEvenNumber(array);