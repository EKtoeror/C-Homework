void Diff(double[] array)
{
    Console.Write("[");

    double diff = 0;
    double max = array[0];
    double min = array[0];

    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(-20, 20);
        Console.Write(array[i]);
        if (i < array.Length - 1)
        {
            Console.Write(",");
        }
        if (array[i] > max)
        {
            max = array[i];
        }
        if (array[i] < min)
        {
            min = array[i];
        }
        diff = max - min;
    }
    Console.Write("]");
    Console.WriteLine();
    Console.WriteLine($"{diff}");
}
double[] array = new double[4];
Diff(array);