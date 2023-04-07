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

Console.Write("input a elements for array: " );
int number = Convert.ToInt32(Console.ReadLine());

double[] RandomArray = new double[number];

  void ShowArray(int number)
  {
     for(int i = 0; i < number; i++)
     {
       RandomArray[i] = new Random().NextDouble();
       Console.Write(RandomArray[i] +" ");
     }
  }
  double num(double[]RandomArray)
  {
    double minValue = RandomArray[0];
    double maxValue = RandomArray[0];
    int i =1;
    while (i < RandomArray.Length)
     {
      if(maxValue<RandomArray[i])
       maxValue = RandomArray[i];
      if(minValue>RandomArray[i])
       minValue = RandomArray[i];
       i=i+1;
     }
   return maxValue - minValue; 
   }
  ShowArray(number);
  Console.Write($"разницу между макс и мин элементов массива: {num(RandomArray)}");
  