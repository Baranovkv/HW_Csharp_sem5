// Задача 38: Задайте массив вещественных чисел. 
// Найдите разницу между максимальным и минимальным элементов массива.

// void FillArrayRand(double[] fillArray)
// {
//     for (int i = 0; i < fillArray.Length; i++)
//         fillArray[i] = new Random().Next(-10,11);
// }

void FillArrayUser(double[] fillArray)
{
    for (int i = 0; i < fillArray.Length; i++)
    {
        Console.Write($"Enter {i+1} number of array:  ");
        fillArray[i] = Convert.ToDouble(Console.ReadLine());
    }
}

void PrintArray(double[] printArray)
{
    string print = "[";
    for (int i = 0; i < printArray.Length-1; i++)
        print = print + printArray[i] + ", ";
    print = print + printArray[printArray.Length-1] + "]";
    Console.WriteLine(print);
}

double DifMaxMin(double[] difArray)
{
    double max = difArray[0];
    double min = difArray[0];
    for (int i = 1; i < difArray.Length; i++) 
        if (difArray[i] > max)
            max = difArray[i];
        else if (difArray[i] < min)
            min = difArray[i];    
    double dif = max - min;
    return dif;
}

Console.WriteLine("Please enter the size of array");
int length = Convert.ToInt32(Console.ReadLine());
double[] array = new double [length];
FillArrayUser(array);
Console.Write("Created array: ");
PrintArray(array);
Console.WriteLine($"Difference between max and min is {Math.Round(DifMaxMin(array), 2)}");