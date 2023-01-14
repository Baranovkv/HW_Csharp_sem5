// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами.
// Напишите программу, которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2

void FillArray(int[] fillArray)
{
    for (int i = 0; i < fillArray.Length; i++)
        fillArray[i] = new Random().Next(100,1000);
}

void PrintArray(int[] printArray)
{
    for (int i = 0; i < printArray.Length; i++)
        Console.Write(printArray[i]+" ");
    Console.WriteLine();
}

int EvenNum(int[] evenArray)
{
    int count = 0;
    for (int i = 0; i < evenArray.Length; i++)
        if (evenArray[i] % 2 == 0)
            count++;
    return count;
}

Console.WriteLine("Please enter the size of array");
int length = Convert.ToInt32(Console.ReadLine());
int[] array = new int [length];
FillArray(array);
Console.Write("Created array: ");
PrintArray(array);
Console.WriteLine($"Even numbers: {EvenNum(array)}");