// Задача 60. ...Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. 
//Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
//Массив размером 2 x 2 x 2
//66(0,0,0) 25(0,1,0)
//34(1,0,0) 41(1,1,0)
//27(0,0,1) 90(0,1,1)
//26(1,0,1) 55(1,1,1)


Console.WriteLine("Введите размер 1 ");
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите размер 2 ");
int b = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите размер 3 ");
int c = Convert.ToInt32(Console.ReadLine());

int[,,] newarray = new int[a, b, c];

CreatFillArray();
PrintArray();

void CreatFillArray()
{
    for (int i = 0; i < newarray.GetLength(0); i++)
    {
        for (int j = 0; j < newarray.GetLength(1); j++)
        {
            for (int k = 0; k < newarray.GetLength(2); k++)
            {
                newarray[i, j, k] = new Random().Next(0, 10);
            }

        }
    }
}

void PrintArray()
{

    for (int i = 0; i < newarray.GetLength(0); i++)
    {
        // int ind1 = i;
        for (int j = 0; j < newarray.GetLength(1); j++)
        {
            //int ind2 = j;
            for (int k = 0; k < newarray.GetLength(1); k++)
            {
                //int ind3 = k;
                Console.Write(newarray[i, j, k] + "[" + (i + "," + j + "," + k) + "] | ");

            }
        }
        Console.WriteLine();

    }
}