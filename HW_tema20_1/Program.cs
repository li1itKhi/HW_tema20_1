Console.Write("Введите первое число: ");
int a_1=int.Parse(Console.ReadLine()!);

Console.Write("Введите второе число: ");
int b_1 = int.Parse(Console.ReadLine()!);

Console.WriteLine($"Сумма чисел равна: {Summa(a_1, b_1)}");
int Summa(int a, int b)
{
    return a + b;
}