// Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
// [3 7 22 2 78] -> 76

int[] GetArray(int size, int minValue, int maxValue)
{
    int[] res = new int[size];
    
    for (int i = 0; i < res.Length; i++)
    {
        res[i] = new Random().Next(minValue, maxValue + 1);
    }
    return res;
}

int maxRes(int[] maxNum)
{
    int resultMax = maxNum[0];
    for (int i = 0; i < maxNum.Length; i++)
    {
       if (maxNum[i] > resultMax) resultMax = maxNum[i];
    }
    return resultMax;
}

int minRes(int[] minNum)
{
    int resultMin = minNum[0];
    for (int i = 0; i < minNum.Length; i++)
    {
        if (minNum[i] < resultMin) resultMin = minNum[i];
    }
    return resultMin;
}

int[] array = GetArray(6, 0, 100);
Console.WriteLine(String.Join(", ", array));
Console.WriteLine($"{maxRes(array) - minRes(array)}");