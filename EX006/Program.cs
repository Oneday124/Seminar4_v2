// Напишите программу, которая принимает на вход число и выдает сумму цифр в числе
int SumOfNumber(int num)
{
    int sum = 0;
    while (num > 0)
    {
        sum = sum + num % 10;
        num = num / 10;
    }
    return sum;
}
System.Console.WriteLine("Введите число: ");
int num = int.Parse(Console.ReadLine()!);

System.Console.WriteLine($"{SumOfNumber(num)}");