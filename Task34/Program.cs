// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, 
// которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2

int[] GetArray(int size, int minValue, int maxValue)
{
    int[] res = new int[size];
    for (int i = 0; i < res.Length; i++)
    {
        res[i] = new Random().Next(minValue, maxValue + 1);
    }
    return res;
}

int ResultArray(int[] eventNum)
{
    int count = 0;
    for (int i = 0; i < eventNum.Length; i++)
    {
        if (eventNum[i] % 2 == 0) count++;
    }
    return count;
}

int[] array = GetArray(4, 100, 999);
Console.WriteLine(String.Join(", ", array));
Console.WriteLine($" {ResultArray(array)}");