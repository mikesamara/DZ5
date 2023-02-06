//Задайте одномерный массив, заполненный случайными числами. 
//Найдите сумму элементов,
//стоящих на нечётных позициях.
Console.WriteLine("Введите размер массива");
int size= Convert.ToInt32(Console.ReadLine()); //задаем размер массивва
int [] arr = new int [size]; // массив
System.Console.WriteLine("Массив");
RandomArray (arr);
int sum = 0;
for (int j = 0; j < arr.Length; j= j+2)
    sum = sum + arr[j];
    System.Console.WriteLine();
    System.Console.WriteLine($"Cумма чисел " + "= " + sum);
// определяем функцию по выводу массива
void RandomArray(int[] arr)
{
    for (int i = 0; i < size; i++)
        {
            arr[i] = new Random().Next(-100,100);
            System.Console.Write(arr[i]+" ");
        }
}

