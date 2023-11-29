// Задача 2: Задайте массив на 10 целых чисел.
// Напишите программу, которая определяет
// количество чётных чисел в массиве.

System.Console.Write("введите количество элементов в массиве: "); 
int size = Convert.ToInt32(Console.ReadLine());
int [] arr = new int[size]; 
Random rand = new Random();
for(int i = 0; i < size; i++)
{
    arr[i] = rand.Next(); 
}
for(int i = 0; i < size; i++)
{
    System.Console.Write(arr[i] + " ");
}

int number = 0;
int itog = 0;
for (int i = 0; i < size; i++)
{
      if (arr[i] % 2 == 0)
      {
        number =  1;
        itog = itog + number;
      }
      

Console.WriteLine( itog + " четных чисел");
     }
   


