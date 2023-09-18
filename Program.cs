/*Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.
[345, 897, 568, 234] -> 2*/

int[] FillArray(int siie, int min, int max)
{
    int[]arr = new int[siie];
    Random rand =new Random();
    for (int i = 0; i< siie; i++)
    {
        
        arr[i] = rand.Next(min,max + 1);
    }
    return arr;
}
int EvenNum (int[]arr)
{
    int count = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i]%2==0)
        count++;
    }
    return count;
}
void PrintArray( int [] arr){

    for (int i = 0; i < arr.Length; i++)
    {
       Console.Write($" {arr[i]} "); 
    }
}
int[] arr = FillArray(10,100,999);
PrintArray(arr);
System.Console.WriteLine();
int newNum = EvenNum (arr);
Console.WriteLine($"Количетсво четных чисел в массиве = {newNum}");

/*Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
[3, 7, 23, 12] -> 19
[-4, -6, 89, 6] -> 0*/

int[] FillArray(int siie, int min, int max)
{
    int[]arr = new int[siie];
    Random rand =new Random();
    for (int i = 0; i< siie; i++)
    {
        
        arr[i] = rand.Next(min,max + 1);
    }
    return arr;
}
int Sum(int[] arr)
{
    int sum = 0;
    for (int i = 1; i < arr.Length; i = i + 2)
    {
        if (arr[i] > -100 && arr[i] < 100)
        {
            sum += arr[i];
        }
    }
    return sum;
}
void PrintArray( int [] arr)
{

    for (int i = 0; i < arr.Length; i++)
    {
       Console.Write($" {arr[i]} "); 
    }
}
int[] arr = FillArray(10,-100,100);
PrintArray(arr);
System.Console.WriteLine();
int sum = Sum (arr);
Console.WriteLine($"Сумма элементов = {sum}");

/*Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
[3.22, 4.2, 1.15, 77.15, 65.2] => 77.15 - 1.15 = 76*/

double[] FillArray(int siie, int min, int max)
{
    double[]arr = new double[siie];
    Random rand = new Random();
    for (int i = 0; i< siie; i++)
    {
        arr[i] = rand.Next(min,max) + rand.NextDouble();
    }
    return arr;
}
double Maxnum (double [] arr)
{
    double max = 0;
    for (int i = 0; i < arr.Length; i++)
    {
    if (arr[i] > max)
        {
            max = arr[i];
        }
    }
    System.Console.WriteLine($"Максимальное число = {max}");
    return max;
}
double Minnum (double [] arr)
{
    double min = 0;
    for (int i = 0; i < arr.Length; i++)
    {
    if (arr[i] < min)
        {
            min = arr[i];
        }
    }
    System.Console.WriteLine($"Минимальное число = {min}");
    return min;
}
void PrintArray( double [] arr)
{
    System.Console.Write("Массив:");
    for (int i = 0; i < arr.Length; i++)
    {
       Console.Write($" {arr[i]} "); 
    }
    System.Console.WriteLine();
}
double[] arr = FillArray(10,-100,100);
PrintArray(arr);
double max = Maxnum(arr);
double min = Minnum(arr);
double sum = max - min;
System.Console.WriteLine($"Разница = {sum}");