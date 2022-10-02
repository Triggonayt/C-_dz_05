void ArrayRandom(int[] array)
{
    for(int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(100,1000);
    }
}
void PrintArray(int[] array)
{
    Console.Write("[ ");
    for(int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + " ");
    }
    Console.Write("]");
    Console.WriteLine();
}



// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. 
// Напишите программу, которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2

// Console.Clear();
// int size = 10;
// int[] array = new int[size];
// ArrayRandom(array);
// PrintArray(array);
// int count = 0;

// for (int i = 0; i < array.Length; i++)
// if (array[i] % 2 == 0)
// count++;

// Console.WriteLine($" {count} Even numbers");



// Задача 36: Задайте одномерный массив, заполненный случайными числами. 
// Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0


// Console.Clear();
// int[] array = new int[8];
// ArrayRandom(array);
// PrintArray(array);
// int sum = 0;

// for (int i = 0; i < array.Length; i+=2)
// sum = sum + array[i];

// Console.WriteLine($"Sum of odd numbers: {sum}");




// Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
// [3 7 22 2 78] -> 76


Console.Clear();
int[] array = new int[6];
ArrayRandom(array);
PrintArray(array);
int min = Int32.MaxValue;
int max = Int32.MinValue;


for (int i = 0; i < array.Length; i++)
{
    if (array[i] > max)
        {
            max = array[i];
        }
    if (array[i] < min)
        {
            min = array[i];
        }
}


Console.WriteLine($"Max = {max}, Min = {min}");
Console.WriteLine($"Difference between Max and Min value = {max - min}");