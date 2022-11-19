// Напишите программу, которая задает массив из 8 элементов и выводит их на экран

void FillArray(int[] array, int max)
{
    for(int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(0,max);
    }
}

void PrintArray (int[] array)
{
    foreach(int element in array)
        Console.Write($"{element} ");
}


System.Console.WriteLine("Введите длинну массива: ");
int a = int.Parse(Console.ReadLine() !);
System.Console.WriteLine("Введите максимальный элемент массива: ");
int max = int.Parse(Console.ReadLine() !);
int [] array = new int[a];

FillArray(array, max);
PrintArray(array);