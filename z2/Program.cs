// Задача 2: Задайте массив на 10 целых чисел.
// Напишите программу, которая определяет
// количество чётных чисел в массиве.

//System.Console.Write("введите количество элементов в массиве: "); 
int size = 10; //Convert.ToInt32(Console.ReadLine());
int [] arr = new int[size]; 
Random rand = new Random(1);
for(int i = 0; i < size; i++)
{
    arr[i] = rand.Next(0, 11); // rand.Next( ) граница массива
}
for(int i = 0; i < size; i++)
{
    System.Console.Write(arr[i] + " ");
}

int number = 0;
for (int i = 0; i < size; ++i)
{
      if (arr[i] % 2 == 0)
      {
        ++number;
      }
      
}
   
   Console.WriteLine("четных чисел " + number );


