using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace Arrays
{
    class Task2
    {
        public void SumMinMax(int[,] nums)
        {
            Random rand = new Random();
            int sum = 0;
            int min = 0;
            int[] minIndex = new int[2];
            int max = 0;
            int[] maxIndex = new int[2];
            WriteLine("Массив 2 задание ");
            for (int i = 0; i < nums.GetLength(0); i++)
            {
                for(int j = 0; j < nums.GetLength(1); j++)
                {
                    nums[i, j] = rand.Next(-100, 100);
                    Write(nums[i, j] + " ");
                }
                WriteLine();
            }

            for (int i = 0; i < nums.GetLength(0); i++)
            {
                for (int j = 0; j < nums.GetLength(1); j++)
                {
                    if (nums[i, j] < min)
                    {
                        min = nums[i, j];
                        minIndex[0] = i;
                        minIndex[1] = j;
                    }
                    if (nums[i, j] > max)
                    {
                        max = nums[i, j];
                        maxIndex[0] = i;
                        maxIndex[1] = j;
                    }
                }
                
            }
            WriteLine($"Минимальное число {min} - Максимальное число {max}");
            if (minIndex[0] > maxIndex[0])
            {
                int temp = minIndex[0];
                minIndex[0] = maxIndex[0];
                maxIndex[0] = temp;
            }
            WriteLine("Массив от минимального к максимальному индексу");
            for (int i = minIndex[0]; i < nums.GetLength(0); i++)
            {
                if (i == minIndex[0])
                {
                    for (int j = minIndex[1]; j < nums.GetLength(1); j++)
                    {
                        Write(nums[i, j] + " ");
                        sum += nums[i, j];
                        if (i == maxIndex[0] && j == maxIndex[1])
                        {
                            break;
                        }
                        
                    }
                    WriteLine();
                }
                else
                {
                    for (int j = 0; j < nums.GetLength(1); j++)
                    {
                        Write(nums[i, j] + " ");
                        sum += nums[i, j];
                        if (i == maxIndex[0] && j == maxIndex[1])
                        {
                            break;
                        }
                    }
                    WriteLine();
                }
                
            }
            WriteLine("Сумма элементов массива " + sum);


        }
    }
}
