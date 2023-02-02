int[] RandArray()
{
    
    Random rnd = new Random();
    int size = rnd.Next(1, 7);
    int[] array = new int[10];
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = rnd.Next(-100, 100);   
    }
    return array;
}

int Summ(int[] array)
{   
    int d;
    int summ = 0;
    for (int i = 0; i < array.Length; i++)//считает числа с нечетными индексами в массиве
    {
        d = i % 2;
        if(d != 0)
        {
            summ+= array[i];
        }
    }
    return summ;

}

int[] array = RandArray();
int summ = Summ(array);

Console.WriteLine(summ);
