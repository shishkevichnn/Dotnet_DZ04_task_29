/*Задача 29: Напишите программу, которая задаёт массив из N элементов, заполненных случайными числами из [a, b) 
и выводит их на экран.
5, 0, 20 -> [1, 2, 5, 7, 19]
3, 1, 35 -> [6, 1, 33]*/
Console.Write("Введите количество элементов в массиве: ");
int N = int.Parse(Console.ReadLine());
Console.Write("Введите диапозон случайных чисел от: ");
int a = int.Parse(Console.ReadLine());
Console.Write("Введите диапозон случайных чисел до: ");
int b = int.Parse(Console.ReadLine());

int[] RandArray(int size, int minValue, int maxValue)
{
    int[] array = new int[size];
        for (int i = 0; i < size; i++)
        {
            array[i] = new Random().Next(minValue, maxValue);
        }
    return array;
}

int[] array = RandArray(N, a, b);
Console.WriteLine($"[{String.Join(", ", array)}]");

