// Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0

Console.Clear();
        Console.WriteLine("Введите количество элементов в массиве");
        int size = Convert.ToInt32(Console.ReadLine());

int[] startArray = GetArray(size, 100 , 1000);
Console.WriteLine(String.Join(" ", startArray));
Console.WriteLine($"Сумма элементов, стоящих на нечетных позициях, = {GetSumElements(startArray, 100, 1000)}");

int[] GetArray(int size, int minValue, int maxValue)
{
    int[] res = new int[size];

    for (int i = 0; i < size; i++)
    {
        res[i] = new Random().Next(100, 1000);
    }
    return res;
}

int GetSumElements(int[] array, int leftRange, int rigthRange)
{
    int sum = 0;
    for (int i = 1; i < array.Length; i+=2)
    {
    sum += array[i];
    }
    return sum;
}