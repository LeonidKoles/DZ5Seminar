// Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным
// и минимальным элементов массива.

void Zadacha38()
{
    int size = 6;
    double [] array = new double[size];

    FillArray(array);
    PrintArray(array);

    double min = 0;
    double max = 0;
    for (int i = 0; i < size; i++)
    {
        if (array[i] > max) max = array[i];
        else min = array[i];
        if (array[i] < min) min = array[i];

    }
    Console.WriteLine($"{min} {max}");
    Console.WriteLine(max - min);

    void FillArray(double[] array)
    {
        Random random = new Random();
        for (int i = 0; i < array.Length; i++)
        {
            array[i] = Math.Round(random.NextDouble() * 100, 2);
        }

    }
    void PrintArray(double[] array)
    {
        for (int i = 0; i < array.Length; i++)
        {
            Console.Write(array[i] + "  ");
        }
        Console.WriteLine();
    }
}
Zadacha38();