/*Задача 38: Задайте массив вещественных чисел.
Найдите разницу между максимальным и минимальным значениями элементов массива.

[3 7 22 2 78] -> 76*/

int size = 5;
int count = 0;
int[] array = new int[size];

for (int i = 0; i < size; i++)
{
    array[i] = new Random().Next(1, 1000);
    if (array[i] % 2 == 0)
    {
        count++;
    }
}