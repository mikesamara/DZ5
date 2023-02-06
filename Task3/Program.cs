//Задайте массив вещественных чисел. 
//Найдите разницу между максимальным и минимальным элементов массива.
Console.WriteLine("Введите размер массива");
int size= Convert.ToInt32(Console.ReadLine()); //задаем размер массивва
int [] arr = new int [size]; // массив
System.Console.WriteLine("Массив");
RandomArray (arr);
int max = arr[1];
int min = arr[1];
int dif = 0;
for (int j = 0; j < size; j++)
{
    if (arr[j] > max)
    {
        max = arr[j];
    }
    if (arr[j] < min)
    {
        min = arr[j];
    }
}
dif = max - min;
System.Console.WriteLine();
System.Console.WriteLine($"Максимальный элемент массива = " + max);
System.Console.WriteLine();
System.Console.WriteLine($"Минимальный элемент массива = " + min);
System.Console.WriteLine();
System.Console.WriteLine($"Разница между максимальным и минимальным элементом массива = " + dif);
// функция заполнения массива
void RandomArray(int[] arr)
{
    for (int i = 0; i < size; i++)
        {
            arr[i] = new Random().Next(1,100);
            System.Console.Write(arr[i]+" ");
        }
}