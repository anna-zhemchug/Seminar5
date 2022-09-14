// Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0

int[] GetArray(int size, int minValue, int maxValue)
{
    int[] res = new int[size];
    for (int i = 0; i < res.Length; i++)
    {
        res[i] = new Random().Next(minValue, maxValue + 1);
    }
    return res;
}

int check(int[] mas)
{
    int sum = 0;
    for (int i = 0; i < mas.Length; i++)
    {
        if (i % 2 != 0)
        {
            sum = sum + mas[i];
        }
    }
    return sum;
}

int[] array = GetArray(4, 0, 100);
Console.WriteLine(String.Join(", ", array));
Console.WriteLine($" {check(array)}");