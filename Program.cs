// ДОМАШНЕЕ ЗАДАНИЕ НОМЕР 5

// Урок 5. Функции продолжение
// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами.
//  Напишите программу, которая покажет количество чётных чисел в массиве.

// [345, 897, 568, 234] -> 2

// int[] array = new int[4];
// int count = 0;
// for (int i = 0; i < array.Length; i++)
// {
//     array[i] = new Random().Next(100, 1000);
//    if (array[i] % 2 == 0)
//    {
//     count++;
//    }
// }

// Console.WriteLine($"[ {String.Join(" ,", array)} ]");
// Console.WriteLine($"Количество чётных трёхзначных элементов массива равно {count}");



// Задача 36: Задайте одномерный массив, заполненный случайными числами. 
// Найдите сумму элементов, стоящих на нечётных позициях.

// [3, 7, 23, 12] -> 19

// [-4, -6, 89, 6] -> 0

// int[] array = new int[4];
// int sum = 0;
// for (int i = 1; i < array.Length; i = i+2)
// {
//     array[i] = new Random().Next(-10,11);
//     sum += array[i];
// }
// Console.WriteLine($"[ {String.Join(" ,", array)} ]");
// Console.WriteLine ($"Сумма элементов, стоящих на нечётных позициях равна {sum}");


// Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.

// [3 7 22 2 78] -> 76

// double[] d = new double[5];
// double max = array[0]; 
// double min = array[0];

// for (int i = 0; i < d.Length; i++)
// {
//     d[i] = new Random().Next(-5,10);
//     if (d[i] > max) max = d[i];
//     if (d[i] < min) min = d[i];
// }

// for (int i = 0; i < d.Length; i++) Console.Write(" " + d[i]);
// Console.WriteLine();
// Console.WriteLine("max:  " + max);
// Console.WriteLine("min  " + min);
// Console.WriteLine("Разница максимального и минимального элементов:  " + (max - min));

// Мишин пример

// double [] array = new double[10];

// for (int i = 0; i < array.Length; i++)
// {
//     array[i] = new Random().NextDouble();
//     Console.Write(array[i] + " ");
// }
// diff = max - min





