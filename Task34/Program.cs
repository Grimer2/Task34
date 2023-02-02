int RandSize(int min, int max)
{
    int size = 0;
    Random rnd = new Random();
    size = rnd.Next(min, max);
    return size;
}

int[] RandArray(int size, int min, int max)
{
    int[] array = new int[size];
    Random rnd = new Random();
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = rnd.Next(min, max);   
    }
    return array;
}

int Schet(int[] array)
{ int schet = 0;
    for (int i =0; i < array.Length; i++)
    {   int del = 0;
        del = array[i] % 2;
        if(del == 0)
        {
            schet++;
        }
    }
    return schet;
}
void PrintArray (int[] array)
{
    Console.Write("[");
    for (int i = 0; i < array.Length; i++)
    {
        if(i < array.Length) {Console.Write($"{array[i]},");}
        else Console.Write($"{array[i]},");
    }
    Console.Write("]");
}
int size = RandSize(0, 100);
int[] array = RandArray(size, 100, 999);
int schet = Schet(array);
PrintArray(array);
Console.WriteLine(schet);
