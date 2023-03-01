
//Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу,
// которая покажет количество чётных чисел в массиве.
//[345, 897, 568, 234] -> 2

Console.Clear();
        Console.WriteLine("Введите количество элементов в массиве");
        int size = Convert.ToInt32(Console.ReadLine());

int[] startArray = GetArray(size, 100 , 1000);
Console.WriteLine(String.Join(" ", startArray));
Console.WriteLine($"Количество четных элементов в массиве = {GetCountElements(startArray, 100, 1000)}");

int[] GetArray(int size, int minValue, int maxValue)
{
    int[] res = new int[size];

    for (int i = 0; i < size; i++)
    {
        res[i] = new Random().Next(100, 1000);
    }
    return res;
}

int GetCountElements(int[] array, int leftRange, int rigthRange)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
    if (array[i] % 2 == 0) count ++;
    }
    return count;
}