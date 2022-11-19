/*Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами.
Напишите программу, которая покажет количество чётных чисел в массиве.

[345, 897, 568, 234] -> 2*/

int size = 5;
int count = 0;
int[] array = new int[size];

for (int i = 0; i < size; i++)
{
    array[i] = new Random().Next(100, 1000);
    if (array[i] % 2 == 0)
    {
        count++;
    }
}

PrintArray(array);

void PrintArray (int[] arrayNum)
{
    for (int i = 0; i < size; i++)
    {
        Console.Write($"{arrayNum[i]} ");
    }
}

Console.Write($"-> {count}");