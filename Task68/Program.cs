Console.WriteLine("Введите неотрицательных числа:");
int number = Convert.ToInt32(Console.ReadLine());
int stop = Convert.ToInt32(Console.ReadLine());

int Akk(int n, int m)
{
    if (n == 0)
        return m + 1;
    else
      if ((n != 0) && (m == 0))
        return Akk(n - 1, 1);
    else
        return Akk(n - 1, Akk(n, m - 1));
}

Console.WriteLine(Akk(number, stop)); 
