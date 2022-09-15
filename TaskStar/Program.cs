// Задача "со звездочкой": Разобраться с алгоритмом сортировки методом пузырька. Реализовать невозрастающую сортировку.
// [3, 0, 2, 4, -1] -> [4, 3, 2, 0, -1]
// [1,2,2,3,2] -> [3, 2, 2, 2, 1]

int[] GetArray(int size, int minValue, int maxValue)
{
    int[] res = new int[size];
    
    for (int i = 0; i < res.Length; i++)
    {
        res[i] = new Random().Next(minValue, maxValue + 1);
    }
    return res;
}

int[] Bubble(int[] mas)
{
    int temp;

    for (int i = 0; i < mas.Length; i++)
    {
        for (int j = i + 1; j < mas.Length; j++)
        {
            if (mas[i] < mas[j])
            {
                temp = mas[i];
                mas[i] = mas[j];
                mas[j] = temp;
            }
        }
    }
    return mas;
}

int[] array = GetArray(5, -100, 100);
Console.WriteLine(String.Join(", ", array));
int[] BubbleArr = Bubble(array);
Console.WriteLine(String.Join(" ", BubbleArr));