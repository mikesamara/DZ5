//Задайте массив заполненный случайными положительными трёхзначными числами. 
//Напишите программу, которая покажет количество чётных чисел в массиве.
int [] array = new int [10];
Random rnd = new Random();
int j = 0;
for (int i = 0; i < array.Length; i++)
{
    array[i] = rnd.Next(100, 1000);
    System.Console.Write(array[i] + "," + " ");
            if (array[i] %2 == 0)
            {
               j = j + 1;
            }
}
System.Console.WriteLine();
System.Console.WriteLine($"Четныйх чисел в массиве" + " " + j);
