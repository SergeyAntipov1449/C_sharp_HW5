// Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0

int[] ArrayGeneration(int size)
{
    Random rand = new Random();
    int[] array = new int[size];
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = rand.Next(-999, 1000);
    }
    System.Console.WriteLine("[" + string.Join(", ", array) + "]");
    return array;
}

void OddSum(int [] array)
{
    int sum = 0;
    for (int i =1; i < array.Length; i+=2)
    {
        sum = sum +array[i];
    }
    System.Console.WriteLine(sum);
}

int [] array = ArrayGeneration(10);
OddSum(array);