// Задача 30: - HARD необязательная Напишите программу, которая на вход получает размерность массива. 
// Далее заполняет его случайными уникальными числами и выводит на экран. 
// Далее производим сортировку массива от большего к меньшему и выводим на экран. 
// Далее придумываем алгоритм перемешивания списка на основе случайности ,
// применяем этот алгоритм и выводим на экран результат. 
// Встроенные методы работы со списками использовать нельзя.

void FillArrayUniqRand(double[] fillArray) // заполняем уникальными случайными числами
{
    int temp = new Random().Next(0,10); // переменная для значения каждого нового элемента массива
    fillArray[0] = new Random().Next(0,10); // первый элемент сразу задаем случайно
    
    for (int i = 1; i < fillArray.Length; i++)  // берем по очереди со второго каждый элемент массива
    {
        for (int j = i; j > 0; j--) // сравниваем переменную со случайным значением с уже заполненными элементами
            while (temp == fillArray[j - 1]) // пока она не содержит уникальное значение, обновляем его
            {
                temp = new Random().Next(0, 10);
                j = i;
            }
        fillArray[i] = temp; // после присваиваем уникальное значение новому элементу массива
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

void BubleSortMaxMin(double[] sortArray) // метод пузырьковой сортировки
{
    for (int i = 0; i < sortArray.Length-1; i++)
        for (int j = i; j < sortArray.Length; j++)
            if (sortArray[i] < sortArray[j])
                (sortArray[i], sortArray[j]) = (sortArray[j], sortArray[i]);
}

void RandomSort(double[] randArray, int length) // случайная сортировка
{
    int temp;
    for (int i = 0; i < randArray.Length; i++) // каждый элемент массива получает случайное место в его границах
    {
        temp = new Random().Next(0,length);
        (randArray[i], randArray[temp]) = (randArray[temp], randArray[i]);
    }
}


Console.WriteLine("Please enter the size of array");
int length = Convert.ToInt32(Console.ReadLine());
double[] array = new double [length];
FillArrayUniqRand(array);
Console.WriteLine("Created array with unique randome numbers:");
PrintArray(array);
BubleSortMaxMin(array);
Console.WriteLine("Buble sort array:");
PrintArray(array);
RandomSort(array, length);
Console.WriteLine("Random sort array:");
PrintArray(array);