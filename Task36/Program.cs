double[] RandArray()
{
    
    Random rnd = new Random();
    int size = rnd.Next();
    double[] array = new double[size];
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = rnd.Next(-100, 100);   
    }
    return array;
}
double Max(double[] array)
{   
    double max = 0;
    for (int i = 0; i < array.Length; i++)
    {   
        if(max > array[i]){
            max = array[i];
        }
        
    }
    return max;
}
double Min(double[] array)
{   
    double min = 0;
    for (int i = 0; i < array.Length; i++)
    {   
        if(min < array[i] || i == 0){
            min = array[i];
        }
        
    }
    return min;
}
double[] array = RandArray();
double max = Max(array);
double min = Min(array);
max = max + min;
Console.WriteLine(max);