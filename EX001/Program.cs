// Напишите программу, которая принимает на вход число А и выдает сумму чисел от 1 до А

int Sum (int a)
{
    //    int sum = 0;
    //    for(int i = 0; i <= a; i++)
    //    {
    //        sum += i;
    //    }
    //    return sum;
    return (1 + a) * a / 2;
}


System.Console.WriteLine("Введите число А: ");
int a = int.Parse(Console.ReadLine() !);

Console.WriteLine($"{Sum(a)}");
