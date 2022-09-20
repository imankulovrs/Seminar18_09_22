/* /* Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.

[345, 897, 568, 234] -> 2 */



int[] FillArray(int size)
{
    int[] numbers = new int[size];
    for (int i = 0; i < numbers.Length; i++)
    {
        numbers[i] = new Random().Next(100,1000);
    }
    return numbers;

}
int CountMultiple(int[] array)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if(array[i] % 2 == 0)
        {
            count++;
        }
    }
    return count;
}
int DataEntry(string message)
{
    Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());

}
int size = 10;
int[] numbers = FillArray(size);

Console.WriteLine("[{0}]", string.Join(",", numbers));
System.Console.WriteLine($"В массиве {CountMultiple(numbers)} кратные числа {2}");