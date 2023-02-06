//Задайте массив вещественных чисел. 
//Найдите разницу между максимальным и минимальным элементов массива.
Console.WriteLine("Введите размер массива");
int size= Convert.ToInt32(Console.ReadLine()); //задаем размер массивва
double[] arr = new double[size]; // массив
System.Console.WriteLine("Массив");
RandomArray (arr);
double max = arr[1];
double min = arr[1];
double dif = 0;
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
void RandomArray(double[] arr)
{
    for (int i = 0; i < size; i++)
        {
            arr[i] = Convert.ToDouble(new Random().Next(100,1000))/100;
            System.Console.Write(arr[i]+" ");
        }
}