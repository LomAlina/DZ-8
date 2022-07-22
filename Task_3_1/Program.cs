// *(Вариант 2. Расчет произведения как в примере ниже: умножение элемента одной матрицы на аналогичный элемент другой матрицы)
// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
// Например, заданы 2 массива:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// и
// 1 5 8 5
// 4 9 4 2
// 7 2 2 6
// 2 3 4 7
// Их произведение будет равно следующему массиву:
// 1 20 56 10
// 20 81 8 6
// 56 8 4 24
// 10 6 24 49

int[,] GetArray(int m, int n)
{
    int[,] result = new int[m, n];
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            result[i, j] = new Random().Next(11);
        }
    }
    return result;
}
void PrintArray(int[,] inputArray)
{
    for (int i = 0; i < inputArray.GetLength(0); i++)
    {
        for (int j = 0; j < inputArray.GetLength(1); j++)
        {
            Console.Write(inputArray[i, j] + "\t");
        }
        Console.WriteLine();
    }
}

Console.Write("Введите количество строк 1-й матрицы: ");
int k = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите количество столбцов 1-й матрицы: ");
int l = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите количество строк 2-й матрицы: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите количество столбцов 2-й матрицы: ");
int n = Convert.ToInt32(Console.ReadLine());

int[,] firstMatrix = GetArray(k, l);
Console.WriteLine("Первая матрица:");
PrintArray(firstMatrix);

Console.WriteLine();

int[,] secondMatrix = GetArray(m, n);
Console.WriteLine("Вторая матрица:");
PrintArray(secondMatrix);

int [,] resultMatrix = new int [k,n];
for (int i = 0; i < k; i++)
{
    for (int j = 0; j < n; j++)
    {
        resultMatrix[i,j] += firstMatrix[i,j]*secondMatrix[i,j];
    }
}
Console.WriteLine();
Console.WriteLine("Произведение матриц:");
PrintArray(resultMatrix);