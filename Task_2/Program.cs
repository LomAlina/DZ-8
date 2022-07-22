// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка

Console.WriteLine("Введите размер прямоугольного двумерного массива: ");
int rows = Convert.ToInt32(Console.ReadLine());
int columns = Convert.ToInt32(Console.ReadLine());

int [,] GetArray (int m, int n, int min, int max) 
{
    int [,] result = new int[m,n];
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            result [i,j] = new Random().Next(min, max+1);
        }
    }
    return result;
}

void PrintArray (int[,] inputArray)
{
  for (int i = 0; i < inputArray.GetLength(0); i++)
    {
        for (int j = 0; j < inputArray.GetLength(1); j++)
        {
            Console.Write(inputArray[i,j] + "\t");
        }
        Console.WriteLine();
    }
}

int [,] array = GetArray(rows,columns,0,10);
Console.WriteLine("Массив:");
PrintArray(array);
Console.WriteLine();

int indexRow = 0;
int minsum = Int32.MaxValue;

for (int i = 0; i < array.GetLength(0); i++)
{
    int sum = 0;
    for (int j = 0; j < array.GetLength(1); j++)
    {
        sum += array[i, j];        
    }
    if (sum < minsum)
    {
        minsum = sum;
        indexRow++;
    }
}

Console.WriteLine($"Cтрока под номером {indexRow} имеет наименьшую сумму элементов, равную {minsum}");