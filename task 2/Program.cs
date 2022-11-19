/*Задача 38: Задайте массив вещественных чисел.
Найдите разницу между максимальным и минимальным значениями элементов массива.

[3 7 22 2 78] -> 76*/

int size = 10;
double[] array = new double[size];
double minArr = 100;
double maxArr = 0;

for (int i = 0; i < size; i++)
{
    array[i] = new Random().NextDouble() * 100;
    array[i] = Math.Round(array[i], 2);
}

void PrintArray (double[] arrayNum)
{
    for (int i = 0; i < size; i++)
    {
        Console.Write($"{arrayNum[i]} ");
    }
}

PrintArray(array);

for (int i = 0; i < size; i++)
{
    if (array[i] < minArr)
        minArr = array[i];
}

for (int i = 0; i < size; i++)
{
    if (array[i] > maxArr)
        maxArr = array[i];
}
Console.Write($"-> {Math.Round(maxArr - minArr, 2)}");