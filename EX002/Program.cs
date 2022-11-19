// Напишите программу, которая принимает на вход число и выдает количество цифр в числе

int Counter (int number)
{
    int i = 0;
    if(number < 0) number = number * (-1);
    if(number == 0) i = 1;
    while(number > 0)
    {
        i++;
        number = number / 10;
    }
    return i;
}

System.Console.WriteLine("Введите число: ");
int number = int.Parse(Console.ReadLine() !);


Console.WriteLine($"{Counter(number)}");