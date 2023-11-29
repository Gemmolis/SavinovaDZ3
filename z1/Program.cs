// Задача 1: Задайте одномерный массив из 10 целых чисел от 1 до 100. Найдите количество элементов 
// массива, значения которых лежат в отрезке [20,90]. 
//Пример: массив [10 21 14 93 23] => 2

Console.WriteLine("Введите любое число");
int size = Convert.ToInt32(Console.ReadLine());
int[] arr = new int [10];
Random r = new Random ();
for (int i = 0; i < 10; i++)
arr[i] = r.Next(1,100);
for (int i=0; i <10; i++)
Console.Write(arr[i] + " ");


