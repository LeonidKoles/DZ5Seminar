// Задача 34: Задайте массив заполненный случайнымиположительными трёхзначными числами. 
// Напишитепрограмму, которая покажет количество чётных чисел вмассиве.

void Zadacha34()
{
    int size = 10;
    int[] array = new int[size];

    FillArray(array);
    PrintArray(array);

    int count = 0;
    for (int i = 0; i < size; i++)
    {
        if (array[i] % 2 == 0) count += 1;
    }

    Console.WriteLine(count);

    void FillArray(int[] array)
    {
        Random random = new Random();
        for (int i = 0; i < array.Length; i++)
        {
            array[i] = random.Next(100, 1000);
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

}
Zadacha34();