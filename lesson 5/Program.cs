int size = 12;
int min = -9;
int max = 9;
int positiveSum = 0;
int negativeSum = 0;

int[] numbers = new int[size];

for (int i = 0; i < numbers.Length; i++)
{
    numbers[i] = new Random().Next(min, max + 1);
}
WriteArray(numbers);

for (int i = 0; i < numbers.Length; i++)
{
    if (numbers[i] > 0)
        positiveSum += numbers[i];
    else
        negativeSum += numbers[i];
}
Console.WriteLine($"Положительная сумма = {positiveSum}, отрицательная сумма = {negativeSum}");

void WriteArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + " ");
    }
    Console.WriteLine();
}