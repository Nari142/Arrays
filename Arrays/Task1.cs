using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace Arrays
{
    class Task1
    {
        
        public void Filling(int[] array1, int[,] array2)
        {
            Random r = new Random();
            for (int i = 0; i < array1.Length; i++)
            {
                WriteLine("Введите значения массива A");
                array1[i] = Int32.Parse(ReadLine());
            }
            WriteLine("Массив A");
            for (int i = 0; i < array1.Length; i++)
            {
                Write(array1[i] + " ");
            }
            WriteLine();
            WriteLine("Массив B");
            for (int i = 0; i < array2.GetLength(0); i++)
            {
                for (int j = 0; j < array2.GetLength(1); j++)
                {
                    array2[i, j] = r.Next(0, 100);
                    Write(array2[i, j] + " ");
                }
                WriteLine();
            }

        }
        public void MaxMin(int[] array1, int[,] array2)
        {
            int max = array1[1];
            int min = array1[1];
            for(int i = 0; i < array1.Length; i++)
            {
                if (array1[i] > max)
                {
                    max = array1[i];
                }
                if (array1[i] < min)
                {
                    min = array1[i];
                }
            }
            for (int i = 0; i < array2.GetLength(0); i++)
            {
                for (int j = 0; j < array2.GetLength(1); j++)
                {
                    if (array2[i, j] > max)
                    {
                        max = array2[i, j];
                    }
                    if (array2[i, j] < min)
                    {
                        min = array2[i, j];
                    }
                }
            }
            WriteLine("Максимальное число " + max);
            WriteLine("Минимальное число " + min);
        }
        public void Sum(int[] array1, int[,] array2)
        {
            int sum = 0;
            for(int i = 0; i < array1.Length; i++)
            {
                sum += array1[i];
            }
            for (int i = 0; i < array2.GetLength(0); i++)
            {
                for (int j = 0; j < array2.GetLength(1); j++)
                {
                    sum += array2[i, j];
                }
            }
            WriteLine("Сумма всех элементов " + sum);
        }
        public void Mult(int[] array1, int[,] array2)
        {
            int mult = 1;
            for (int i = 0; i < array1.Length; i++)
            {
                mult *= array1[i];
            }
            for (int i = 0; i < array2.GetLength(0); i++)
            {
                for (int j = 0; j < array2.GetLength(1); j++)
                {
                    mult *= array2[i, j];
                }
            }
            WriteLine("Умножение всех элементов " + mult);
        }
        public void Misc(int[] array1, int[,] array2)
        {
            int sumA = 0;
            int sumB = 0;
            for (int i = 0; i < array1.Length; i++)
            {
                if (array1[i] % 2 == 0)
                {
                    sumA += array1[i];
                }
            }
            WriteLine("Сумма чётных элементов массива A " + sumA);
            for (int i = 0; i < array2.GetLength(0); i++)
            {
                for (int j = 0; j < array2.GetLength(1); j++)
                {
                    if(j % 2 == 0)
                    {
                        sumB += array2[i, j];
                    }
                }   
            }
            WriteLine("Сумма нечётный столбцов массива B " + sumB);
        }
    }
}
