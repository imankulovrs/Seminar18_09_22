/* Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.

[3 7 22 2 78] -> 76 */ 
int DataEntry(string message)
{
    Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}
void FillArray(double[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(-99,100);
    }
}
double Diff(double[] array)
{
    double max = array[0];
    double min = array[0];
    for (int i = 1; i < array.Length; i++)
    {
        if(array[i]> max)
        {
            max = array[i];
        }
        else if(array[i] < min)
        {
            min = array[i];
        }
    }
    return max - min;
}
int size = DataEntry("Введи размер ");
double[] numbers = new double[size];
FillArray(numbers);
Console.WriteLine("[{0}]", string.Join(",", numbers));
Console.WriteLine();
Console.WriteLine($"Итоговое значение {Diff(numbers)}");