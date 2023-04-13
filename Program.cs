
// seminar 3
// Task 1. Напишите программу, которая принимает на вход сичло (А) и выдает сумму чисел от 1 до А.

// int GetSum(int num)

// {
//   int sum = 0;
//   for(int current = 1; current <= num; current++)
//   sum = sum + current;
//   return sum;
// }
// Console.Write("Введите число а: ");
// int a = Convert.ToInt32(Console.ReadLine());

// int result = GetSum(a);
// Console.WriteLine($"sum of numbers from 1 to {a} is {result} ");


// Задайте массив из 12 элементов заполнеными случайными числами с промещутком от -9 до 9. 
// Найдите сумму отрицательных элементов массива.

// int[] GenRandomArray(int size, int min, int max)
// {
//    int[] array = new int [size];
//    for (int i = 0; i<size; i++)
//     array[i] = new Random().Next(min, max +1);
//     return array;
// }
// void ShowArray(int[] array)
// {
//   for(int i = 0; i< array.Length; i++)
//    Console.Write(array[i] + " ");
//    Console.WriteLine();
// }



// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. 
// Напишите программу, которая покажет количество чётных чисел в массиве.

// Console.Write("input a elements for array: " );
// int number = Convert.ToInt32(Console.ReadLine());

// int[] RandomArray = new int [number];

//   void ShowArray(int number)
//    {
//      for(int i = 0; i < number; i++)
//       {
//        RandomArray[i] = new Random().Next(99,1000);
//        Console.Write(RandomArray[i] +" ");
//       }
//    }
//     int sum(int[] number)
//    {
//      int sum = 0;
//      for (int i = 0; i < RandomArray.Length; i++)
//      {
//      if (number[i] %2 == 0)
//      sum++;
//      }
//     return sum;
//    }
   
//  ShowArray(number);
// Console.Write($"Количество четных чисел в массиве: {sum(RandomArray)}");

// Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму 
// элементов, стоящих на нечётных позициях.

// Console.Write("input a elements for array: " );
// int number = Convert.ToInt32(Console.ReadLine());

// int[] RandomArray = new int [number];

//   void ShowArray(int number)
//    {
//      for(int i = 0; i < number; i++)
//       {
//        RandomArray[i] = new Random().Next(1, 100);
//        Console.Write(RandomArray[i] +" ");
//       }
//    }
//      int sum(int[] number)
//     {
//       int sum = 0;
//       int i = 0;
//       while (i < RandomArray.Length)
//       {
//       sum = sum+RandomArray[i];
//       i=i+2;
//       }
//      return sum;
//     }
// ShowArray(number);
// Console.Write($"сумма нечетных элементов в массиве: {sum(RandomArray)}");

// Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и 
// минимальным элементов массива.

// Console.Write("input a elements for array: " );
// int number = Convert.ToInt32(Console.ReadLine());

// double[] RandomArray = new double[number];

//   void ShowArray(int number)
//   {
//      for(int i = 0; i < number; i++)
//      {
//        RandomArray[i] = new Random().NextDouble();
//        Console.Write(RandomArray[i] +" ");
//      }
//   }
//   double num(double[]RandomArray)
//   {
//     double minValue = RandomArray[0];
//     double maxValue = RandomArray[0];
//     int i =1;
//     while (i < RandomArray.Length)
//      {
//       if(maxValue<RandomArray[i])
//        maxValue = RandomArray[i];
//       if(minValue>RandomArray[i])
//        minValue = RandomArray[i];
//        i=i+1;
//      }
//    return maxValue - minValue; 
//    }
//   ShowArray(number);
//   Console.Write($"разницу между макс и мин элементов массива: {num(RandomArray)}");
  
  // Напишите программу, которая перевернёт одномерный массив (последний элемент будет 
  // на первом месте, а первый - на последнем и т.д.)

  // void ReverseArray(int[] array)
  // {
  //   for (int left = 0, right = array.Length - 1; left < right; left++, right--)
  //   {
  //     int temp = array[left];
  //     array[left] = array[right];
  //     array[right] = temp;
  //   }
  // }

  // int[] myArray = {1,2,3,4,5,6};
  // ReverseArray(myArray);

  // for(int i =0; i < myArray.Length; i++)
  // Console.Write(myArray[i] + " ");


// Напишите программу, которая принимает на вход три числа и проверяет, может ли 
// существовать треугольник с сторонами такой длины.

// Не используя рекурсию, выведите первые N чисел Фибоначчи. Первые два числа 
// Фибоначчи: 0 и 1.

// Напишите программу, которая будет создавать копию заданного массива с помощью 
// поэлементного копирования.


// Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.

// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)
// mathprofi

// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел 
// больше 0 ввёл пользователь.

/*
Console.Write("Ведите числа a: ");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Ведите числа b: ");
int num2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Ведите числа c: ");
int num3 = Convert.ToInt32(Console.ReadLine());
Console.Write("Ведите числа d: ");
int num4 = Convert.ToInt32(Console.ReadLine());
int count = 0;
if(num1>0) 
  count++;
if (num2>0)
  count++;
if (num3>0)
  count++;
if (num4>0)
  count++;
   
Console.WriteLine(count);
*/

// Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.

// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)
// mathprofi

// Console.Write("Ведите числа a: ");
// int b1 = Convert.ToInt32(Console.ReadLine());
// Console.Write("Ведите числа b: ");
// int k1 = Convert.ToInt32(Console.ReadLine());
// Console.Write("Ведите числа c: ");
// int b2 = Convert.ToInt32(Console.ReadLine());
// Console.Write("Ведите числа d: ");
// int k2 = Convert.ToInt32(Console.ReadLine());
// int x = -1;

// int y1 = k1 * x + b1;
// int y2 = k2 * x + b2;

// Console.WriteLine(y1);
// Console.WriteLine(y2);


// Семинар 7 13.04.23

// Задайте двумерный массив размером m×n, заполненный случайными целыми числами.

int[,] CreateRandom2dArray()
{
  Console.Write(" ВВедите количество строк: ");
int rows = Convert.ToInt32(Console.ReadLine());
Console.Write(" ВВедите количество columns: ");
int columns = Convert.ToInt32(Console.ReadLine());
Console.Write(" ВВедите количество minValue: ");
int minValue = Convert.ToInt32(Console.ReadLine());
Console.Write(" ВВедите количество maxValue: ");
int maxValue = Convert.ToInt32(Console.ReadLine());
  int[,] array = new int[rows, columns];

   for(int i = 0; i < rows; i++)
    
      for(int j = 0; j < columns; j++)
     
      array[i,j] = new Random().Next(minValue, maxValue+1);

  return array;

}
void Show2dArray(int[,] array)
{
  for(int i = 0; i < array.GetLength(0); i++)
  {
    for(int j = 0; j < array.GetLength(1); j++)
     Console.Write(array[i,j] + "   ");

     Console.WriteLine();
  }
  Console.WriteLine();
}
int[,] myArray = CreateRandom2dArray();
Show2dArray(myArray);

// Задайте двумерный массив размера m на n, каждый элемент в массиве находится по 
// формуле: Aij = i+j. Выведите полученный массив на экран.

// Задайте двумерный массив. Найдите элементы, у которых оба индекса чётные, 
// и замените эти элементы на их квадраты.

// Задайте двумерный массив. Найдите сумму элементов, находящихся на главной 
// диагонали (с индексами (0,0); (1;1) и т.д.
  
