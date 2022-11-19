// Написать цикл который принимает на вход 2 числаи возводит число А в степень Б
int Exponentiation(int a, int b)
{
    int result = 1;
    for(int i = 1; i <= b; i++)
    {
        result *= a;
    }
    return result;
}

System.Console.WriteLine("Введите чило А: ");
int a = int.Parse(Console.ReadLine() !);
System.Console.WriteLine("Введите чило B: ");
int b = int.Parse(Console.ReadLine() !);

Console.WriteLine($"{Exponentiation(a, b)}");