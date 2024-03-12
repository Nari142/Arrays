using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace Arrays
{
    class Task4
    {
        public void MatrFill(int[,] matrA, int[,] matrB)
        {
            Random r = new Random();
            WriteLine("Матрица А");
            for (int i = 0; i < matrA.GetLength(0); i++)
            {
                for (int j = 0; j < matrA.GetLength(1); j++)
                {
                    matrA[i, j] = r.Next(0, 100);
                    Write(matrA[i, j] + " ");
                }
                WriteLine();
            }
            WriteLine("Матрица B");
            for (int i = 0; i < matrB.GetLength(0); i++)
            {
                for (int j = 0; j < matrB.GetLength(1); j++)
                {
                    matrB[i, j] = r.Next(0, 100);
                    Write(matrB[i, j] + " ");
                }
                WriteLine();
            }
        }

        public void MatrInt(int[,] matrA, int numb)
        {
            WriteLine("Умножение матрицы на число");
            for (int i = 0; i < matrA.GetLength(0); i++)
            {
                for (int j = 0; j < matrA.GetLength(1); j++)
                {
                    matrA[i, j] *= numb;
                    Write(matrA[i, j] + " ");
                }
                WriteLine();
            }
        }
        
        public void MartSum(int[,] matrA, int[,] matrB)
        {
            WriteLine("Сложение матриц");
            for (int i = 0; i < matrA.GetLength(0); i++)
            {
                for (int j = 0; j < matrA.GetLength(1); j++)
                {
                    matrA[i, j] += matrB[i, j];
                    Write(matrA[i, j] + " ");
                }
                WriteLine();
            }
        }
    }
}
