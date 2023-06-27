//  Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
// [3.22, 4.2, 1.15, 77.15, 65.2] => 77.15 - 1.15 = 76

double[] ArrayGeneration(int size)
{
    Random rand = new Random();
    double[] array = new double[size];
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = Math.Round(rand.Next(-999, 1000) + rand.NextDouble(),2);
    }
    System.Console.WriteLine("[" + string.Join(" | ", array) + "]");
    return array;
}

void DistMaxMin(double [] array)
{
    double max = 0;
    double min = 0;
    for(int i = 0; i < array.Length; i++)
    {
        if(array[i] > max)
        {
            max = array[i];
        }
        else if (array[i] < min)
        {
            min = array[i];
        }
    }
    System.Console.WriteLine(Math.Round((max - min),2));
    // System.Console.WriteLine(Math.Round((Math.Abs(max) - Math.Abs(min)),2));  // Если необходимо найти разность чисел по модулю 
}


double [] array = ArrayGeneration(5);
DistMaxMin(array);