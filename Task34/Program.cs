/*Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.

[345, 897, 568, 234] -> 2
*/

Console.Write("Введите количество элементов в массиве: ");
int size = Convert.ToInt32(Console.ReadLine());

int[] numbers = new int[size];

FillArrayRandomNumbers(numbers, 100, 999);
WriteArray(numbers);

int count = 0;

for(int i = 0; i < numbers.Length; i++)
{
    if (numbers[i] %2 == 0)
        count++;
}

Console.WriteLine($"Количество четных чисел в массиве: {count}");

void FillArrayRandomNumbers(int[] array, int min, int max)
{
    for(int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(min, max + 1);
    }
}

void WriteArray(int[] array)
{
    for(int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + " ");
    }
    Console.WriteLine();
}