// Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.


int[] array = CreateArray(5, 100, 999);
Console.WriteLine(String.Join(" ", array));
Console.WriteLine($"Количество четных чисел в массиве: {GetCount(array)}");

int [] CreateArray(int size, int minValue, int maxValue)
{
    int[] res = new int[size];
    
    for (int i = 0; i < size; i++)
    {
        res[i] = new Random().Next(minValue, maxValue + 1);
    }
    return res;
}

int GetCount(int[] array)
{
    int count = 0;

   for (int i=0; i<array.Length; i++)
   {
    if (array[i] % 2 == 0)
    count++;
   }
   return count;
}

// Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.

    
int[] SumArray = CreateArray(4, 3, 23);                            
Console.WriteLine(String.Join(" ", SumArray));
Console.WriteLine($"Сумма элементов на нечетных позициях: {NegativSum(SumArray)}");

int NegativSum (int[] array)
{
   int sum = 0;
   
   for (int i=0; i<array.Length; i++)
   {
    if (i % 2 != 0)
    sum += array[i];
   }
   return sum;
}

// Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементом массива.

double[] NegativArr = DoubleArray(10, 0, 10);
Console.WriteLine(String.Join(" ", NegativArr));
Console.WriteLine($"Разница между максимальным и минимальным элементом: {Diff(NegativArr)}");

double[] DoubleArray(int size, int minValue, int maxValue)  
{
    double[] res = new double[size];

    var rand = new Random();

    for (int i = 0; i < size; i++)
    {
        res[i] = Convert.ToDouble(rand.Next(0, 100)/10.0);
    }
    return res;
}

double Diff(double[] array)  

{
    double min = array[0];
    double max = array[0];

    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] < min) min = array[i];
        if (array[i] > max) max = array[i];
    }
    return max - min;
}

