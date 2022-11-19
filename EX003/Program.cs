// Напишите программу, которая принимает на вход число N и выдает произведение чисел от 1 до N
long Composition (int n)
{
    long composition = 1;
    if(n <= 0) composition = -1;
    for(int i = 1; i <= n; i++)
    {
        composition = composition * i;
    }
    return composition;
}

Console.WriteLine("Введите число N: ");
int n = int.Parse(Console.ReadLine() !);

System.Console.WriteLine($"{Composition(n)}");

