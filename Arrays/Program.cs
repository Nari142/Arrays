using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;


namespace Arrays
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] Array1 = new int[5];
            int[,] Array2 = new int[3, 4];

            int[,] Array3 = new int[5, 5];
            //Задание 1.
            /*Task1 task1 = new Task1();
            task1.Filling(Array1, Array2);
            task1.MaxMin(Array1, Array2);
            task1.Sum(Array1, Array2);
            task1.Mult(Array1, Array2);
            task1.Misc(Array1, Array2);
            
            //Задание 2.
            Task2 task2 = new Task2();
            task2.SumMinMax(Array3);

            //Задание 3.
            Task3 task3 = new Task3();
            Write("Введите текст: ");
            string message = ReadLine();
            Write("Введите ключ: ");
            int secretKey = Int32.Parse(ReadLine());
            string encryptedText = task3.Encrypt(message, secretKey);
            WriteLine("Зашифрованное сообщение: " + encryptedText);
            Write("Введите текст который хотите расшифровать: ");
            string messageDesc = ReadLine();
            Write("Введите ключ для расшифровки: ");
            int secretKeyDesc = Int32.Parse(ReadLine());
            string descryptedText = task3.Decrypt(messageDesc, secretKeyDesc);
            WriteLine("Расшифрованное сообщение: " + descryptedText);*/

            //Задание 4
            /*
            int[,] matrA = new int[4, 4];
            int[,] matrB = new int[4, 4];

            //Задание 4.
            Task4 task4 = new Task4();
            task4.MatrFill(matrA, matrB);
            Write("Введите число для его умножения на матрицу: ");
            int numb = Int32.Parse(ReadLine());
            task4.MatrInt(matrA, numb);
            task4.MartSum(matrA, matrB);

            //Задание 5
            WriteLine("Введите арифметическую сумму или разницу");
            string arifm_str = ReadLine();
            Task5 task5 = new Task5();
            WriteLine(task5.arifmetStr(arifm_str));

            //Задание 6

            WriteLine("Введите предложение");
            string str = ReadLine();
            Task6 task6 = new Task6();
            WriteLine(task6.TitleStr(str));*/

            //Задание 7
            WriteLine("Введите текст");
            string text = ReadLine();
            WriteLine("Введите запрещённое слово");
            string textBreak = ReadLine();
            Task7 task7 = new Task7();
            WriteLine(task7.TextCensor(text, textBreak));
        }
    }
}
