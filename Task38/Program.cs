/*Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.

[3 7 22 2 78] -> 76

*/

Console.Write("Введите количество элементов в массиве: ");
int size = Convert.ToInt32(Console.ReadLine());

double[] numbers = new double[size];

FillArrayRandomNumbers(numbers, 0, 99);

WriteArray(numbers);

double minimum = numbers[0];
double maximum = numbers[0];

for(int i = 0; i < numbers.Length; i++)
{
    if (numbers[i]> maximum)
        maximum = numbers[i];
    else if (numbers[i] < minimum)
        minimum = numbers[i];
}

double result = maximum - minimum;

Console.WriteLine($" -> {result}");



void FillArrayRandomNumbers(double[] array, int min, int max)
{
for(int i = 0; i < array.Length; i++)
{
array[i] = new Random().Next(min, max + 1)+ new Random().NextDouble();
}
}

void WriteArray(double[] array)
{
    for(int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + " ");
    }
   
}

