// Задача 58: Задайте две матрицы. Напишите программу, 
// которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18

int[,] array1 = new int[,] { { 2, 4 }, { 3, 2 } };
int[,] array2 = new int[,] { { 3, 4 }, { 3, 3 } };
int[,] arr = new int[array1.GetLength(0), array2.GetLength(1)];

PrintArray(array1);
Console.WriteLine();
PrintArray(array2);
Console.WriteLine("____________________");
ArrayMultiplication();


void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i, j] + " | ");
        }
        Console.WriteLine();
    }
}


void ArrayMultiplication()
{
    for (int i = 0; i < array1.GetLength(0); i++)
    {
        for (int j = 0; j < array2.GetLength(1); j++)
        {
            arr[i, j] = 0;
            for (int k = 0; k < array2.GetLength(0); k++)
            {
                arr[i, j] += array1[i, k] * array2[k, j];

            }
            Console.Write(arr[i, j] + " | ");

        }
        Console.WriteLine();
    }

}