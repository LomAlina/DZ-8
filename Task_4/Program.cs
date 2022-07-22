// Задача 60. Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. 
// Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
// Массив размером 2 x 2 x 2
// 12(0,0,0) 22(0,0,1)
// 45(1,0,0) 53(1,0,1)

// Console.Write("Введите размерность массива: ");
// int size = Convert.ToInt32(Console.ReadLine());
// int[,,] matrix = new int[size, size, size];
// HashSet<int> set1 = new HashSet<int>();
// for (int i = 0; i < matrix.GetLength(0); i++)
// {
//     for (int j = 0; j < matrix.GetLength(1); j++)
//     {
//         for (int k = 0; k < matrix.GetLength(2); k++)
//         {
//             int temp = new Random().Next(10, 100);
//             while (set1.Contains(temp))
//                 {
//                     temp = new Random().Next(10, 100);
//                 }
//                 matrix[i,j,k] = temp;
//                 set1.Add(temp);
//             Console.Write($"{matrix[i, j, k]} ({i}, {j}, {k})" + "\t");
//         }
//         Console.WriteLine();
//     }
//     Console.WriteLine();
// }


Console.Write("Введите размерность массива: ");
int size = Convert.ToInt32(Console.ReadLine());
int[,,] matrix = new int[size, size, size];

GetArray(matrix);
PrintArray(matrix);

void PrintArray (int[,,] matrix)
{
  for (int i = 0; i < matrix.GetLength(0); i++)
  {
    for (int j = 0; j < matrix.GetLength(1); j++)
    {
      for (int k = 0; k < matrix.GetLength(2); k++)
      {
        Console.Write($"{matrix[i, j, k]} ({i}, {j}, {k})" + "\t");
      }
      Console.WriteLine();
    }
    Console.WriteLine();
  }
}

void GetArray(int[,,] matrix)
{
  int[] temp = new int[matrix.GetLength(0) * matrix.GetLength(1) * matrix.GetLength(2)];

  int  number = 10;
  for (int i = 0; i < temp.GetLength(0); i++)
  {
    temp[i] = new Random().Next(10, 100);
    number = temp[i];
    if (i >= 1)
    {
      for (int j = 0; j < i; j++)
      {
        while (temp[i] == temp[j])
        {
          temp[i] = new Random().Next(10, 100);
          j = 0;
          number = temp[i];
        }
          number = temp[i];
      }
    }
  }
  int count = 0; 
  for (int i = 0; i < matrix.GetLength(0); i++)
  {
    for (int j = 0; j < matrix.GetLength(1); j++)
    {
      for (int k = 0; k < matrix.GetLength(2); k++)
      {
        matrix[i, j, k] = temp[count];
        count++;
      }
    }
  }
}