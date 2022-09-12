//Задача 2: Задайте одномерный массив, заполненный случайными числами. Найдите сумму четных элементов, стоящих на нечётных позициях (позиция - индекс элемента в массиве).
//[3, 7, 23, 12] -> 12
//[4, 6, 8, 1, 4] -> 6

Console.WriteLine("Введите размер массива: ");
int N = Convert.ToInt32(Console.ReadLine());
int [] array = new int[N];
FillArray(array);
Console.WriteLine();
PrintArray(array);
int sum = 0;

for (int i = 0; i < array.Length; i++)
{
    if (array[i] % 2 == 0)
    {
        sum += array[i];
        i++;
    }
}
Console.WriteLine($"Сумма элементов на нечётных позициях = {sum} ");

void FillArray(int[] numbers)
{
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(1, 1000);
    }
}
void PrintArray(int[] numbers)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + " ");
    }
    
    Console.WriteLine();
}