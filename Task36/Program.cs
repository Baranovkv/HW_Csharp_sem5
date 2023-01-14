// Задача 36: Задайте одномерный массив, заполненный случайными числами. 
// Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0

void FillArray(int[] fillArray)
{
    for (int i = 0; i < fillArray.Length; i++)
        fillArray[i] = new Random().Next(-10,11);
}

void PrintArray(int[] printArray)
{
    for (int i = 0; i < printArray.Length; i++)
        Console.Write(printArray[i]+" ");
    Console.WriteLine();
}

int OddSum(int[] oddArray)
{
    int sum = 0;
    for (int i = 0; i < oddArray.Length; i++) 
        if (i % 2 > 0)                          // find numbers with odd index
            sum += oddArray[i];
    return sum;
}

Console.WriteLine("Please enter the size of array");
int length = Convert.ToInt32(Console.ReadLine());
int[] array = new int [length];
FillArray(array);
Console.Write("Created array: ");
PrintArray(array);
Console.WriteLine($"Sum of numbers with odd position: {OddSum(array)}");