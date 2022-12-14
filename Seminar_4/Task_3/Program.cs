void FillArray(int[] collection)
{
    int length = 8;//collection.Length;
    
    for (int i=0;i < length; i++)
    {
        collection[i] = new Random().Next(1, 10);
        Console.Write(collection[i]);
        if (i < length - 1) 
            {
                Console.Write(",");
            }
    }
}

int[] array = new int[8]; 
FillArray(array);



