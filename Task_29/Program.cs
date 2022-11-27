/* Задача 29:
Напишите программу, которая задаёт массив из N элементов и выводит их на экран.
Вывод сделать отдельным методом.
5 -> [1, 2, 5, 7, 19]
3 -> [6, 1, 33]  */


Console.WriteLine("Введите размер массива: ");
int size = Convert.ToInt32(Console.ReadLine());
int[] numbers = new int[size];

arrayRandom (numbers, 0, 10);
WriteArray(numbers);

void arrayRandom (int[] array, int min, int max)
{
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(min, max);
    }
}
void WriteArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + " ");
    }
}