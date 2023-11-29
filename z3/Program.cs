// Задача 3: Задайте массив из вещественных чисел с
// ненулевой дробной частью. Найдите разницу между
// максимальным и минимальным элементов массива.

System.Console.Write("Введите количетво элементов в массиве: ");
int size = Convert.ToInt32(Console.ReadLine());
double[] arr = new double[size];
Random random = new Random();

int number = random.Next(0, 100);

for (int i = 0; i < size; i++)
    arr[i] = Math.Round((double)random.Next(1, 5) + random.NextDouble(), 2); 
for (int i = 0; i < size; i++)
    Console.Write(arr[i] + " ");
Console.WriteLine();

double min = double.MaxValue;
double max = double.MinValue;

for (int i = 0; i < size; i++)
{
    if (arr[i] < min)
    min = arr[i];
    if (arr[i] > max)
    max = arr[i];
}
     Console.WriteLine($"Искомое значение =  {max - min}");
      