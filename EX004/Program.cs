// Напишите программу, которая выводит массив из 8 элеменов, заполненный нулями и единицами в случайном порядке

void FillArray(int[] array)
{
    for(int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(0,2);
    }
}
void PrintArray(int[] array)
{
    foreach(int element in array)
        Console.Write($"{element} ");
}

int i = 8;
int[] array = new int[i];

FillArray(array);
PrintArray(array);