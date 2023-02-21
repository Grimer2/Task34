
Console.WriteLine("Введите натуральные числа:");
int number = Convert.ToInt32(Console.ReadLine());
int stop = Convert.ToInt32(Console.ReadLine());
int schet = 0;

if (number > stop) 
{
    stop-=1;
    NaturalNumbers(number, stop);
    Console.Write($"{schet} ");
}
if (stop > number) 
{
    number-=1;
    NaturalNumbers2(number, stop);
    Console.Write($"{schet} ");
}

void NaturalNumbers(int num, int num2)
{
    if(num == num2) return;
    NaturalNumbers(num - 1, num2);
    schet+=num;
}

void NaturalNumbers2(int num, int num2)
{
    if(num2 == num) return;
    NaturalNumbers(num2 - 1, num);
    schet+=num2;
}
