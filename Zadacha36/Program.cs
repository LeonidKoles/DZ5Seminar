// Задача 36: Задайте одномерный массив, заполненный случайными числами. 
// Найдите сумму элементов, стоящих на нечётных позициях.

void Zadacha36()
{
    int size = 10;
    int[] array = new int[size];

    int sum = 0;
    for (int i = 1; i < size; i += 2)
    {
        sum += array[i];
    }

    Console.WriteLine(sum);

    
    void FillArray(int[] array)
    {
        Random random = new Random();
        for (int i = 0; i < array.Length; i++)
        {
            array[i] = random.Next(0, 100);
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
}
Zadacha36();