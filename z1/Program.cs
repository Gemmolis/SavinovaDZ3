// Задача 1: Задайте одномерный массив из 10 целых чисел от 1 до 100. Найдите количество элементов 
// массива, значения которых лежат в отрезке [20,90]. 
//Пример: массив [10 21 14 93 23] => 2


int size = 10; 
int min = 19;
int max = 91;

int [] arr = new int[size]; 
Random rand = new Random();
for (int i = 0; i < size; i++)
{
    arr[i] = rand.Next(1, 100); 
}
for (int i = 0; i < size; i++)
{
    System.Console.Write(arr[i] + " ");
}

int number = 0;
for (int i = 0; i < size; ++i)
{
      if (arr[i] > min && arr[i] < max)
      {
        ++number;
      }
      
}
   
   Console.WriteLine("Искомых чисел: " + number );

