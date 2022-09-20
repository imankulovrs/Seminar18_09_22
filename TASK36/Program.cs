/* Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.

[3, 7, 23, 12] -> 19

[-4, -6, 89, 6] -> 0 */
void FillArray(int[] array, int size)
{
    for (int i = 1; i < size; i++)
    {
        array[i] = new Random().Next(-99,100);
    }
}
int DataEntry(string message)
{
    System.Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}
int Sum(int[] array)
{
    int result = 0;
    for (int i = 0; i < array.Length; i+=2)
    {
        
        result += array[i];
    }
    return result;
}
int size = DataEntry("Введи размер массива  ");
int[] numbers = new int[size];
FillArray(numbers, size);
Console.Write($"[{0}]", string.Join(",", numbers));
Console.WriteLine();
Console.WriteLine($"Сумма {Sum(numbers)}");
