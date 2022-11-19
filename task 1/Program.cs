/*Задача 36: Задайте одномерный массив, заполненный случайными числами.
Найдите сумму элементов, стоящих на нечётных позициях.

[3, 7, 23, 12] -> 19

[-4, -6, 89, 6] -> 0*/

int size = 5;
int min = -100;
int max = 100;
int[] array = new int[size];
int sum = 0;

for (int i = 0; i < size; i++)
{
    array[i] = new Random().Next(min, max + 1);
}

for (int i = 0; i < size; i += 2)
{
    sum = sum + array[i];
}

PrintArray(array);

void PrintArray(int[] arrayNum)
{
    for (int i = 0; i < size; i++)
    {
        Console.Write($"{arrayNum[i]} ");
    }
}

Console.Write($"-> {sum}");