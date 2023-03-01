//Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
//[3 7 22 2 78] -> 76

Console.WriteLine("Введите размер массива");
    int size = Convert.ToInt32(Console.ReadLine());

    double [] numbers = new double[size];
    FillArrayRandomNumbers(numbers);
    Console.WriteLine("Вот наш массив: ");
    Console.WriteLine(String.Join(" ", numbers));

    double min = Int32.MaxValue;
    double max = Int32.MinValue;

    for (int n = 0; n < numbers.Length;  n++)
    {
        if (numbers[n] > max)
            {
                max = numbers[n];
            }
        if (numbers[n] < min)
            {
                min = numbers[n];
            }
    }
    Console.WriteLine($"Разница между максимальным и минимальным значением = {max - min}");

    void FillArrayRandomNumbers(double[] numbers)
    {
        for(int i = 0; i < numbers.Length; i++)
            {
                numbers[i] = Convert.ToDouble(new Random().Next(100,1000)) / 100;
            }
    }