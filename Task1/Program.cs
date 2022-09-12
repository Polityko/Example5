//Задача 1: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.

//[345, 897, 568, 234] -> 2
int[] numbers = new int[7];
FillArray(numbers, 100, 1000);
PrintArray(numbers);

int count = PosNum(numbers);
int PosNum(int[] array)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] % 2 == 1)
        {
            count++;
        }
    }
    return count;
}

void FillArray(int[] array, int start, int stop)
{
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(start, stop);
    }
}

void PrintArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + " ");
    }
    Console.WriteLine();
}


Console.WriteLine($"Четных чисел: {count}");
