/*Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.

[3, 7, 23, 12] -> 19
[-4, -6, 89, 6] -> 0
*/

Console.Write("Введите количество элементов в массиве: ");
int size = Convert.ToInt32(Console.ReadLine());

int[] numbers = new int[size];

FillArrayRandomNumbers(numbers, -99, 99);
WriteArray(numbers);

int sum = 0;

for(int i = 0; i < numbers.Length; i+=2)
{
        sum = sum + numbers[i];
}

Console.WriteLine($"Сумма элементов, стоящих на нечетных позициях: {sum}");

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

