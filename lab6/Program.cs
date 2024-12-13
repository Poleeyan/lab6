using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
namespace lab6_task1
{
    internal class Program
    {
        static int Max(int x, int y) // Функція для обчислення максимального з двох чисел
        {
            return x > y ? x : y;
        }
        static void Main()
        {
            Console.Write("Введiть перше число (a): "); //Ввести два числа a та b
            int a = int.Parse(Console.ReadLine());
            Console.Write("Введiть друге число (b): ");
            int b = int.Parse(Console.ReadLine());
            int max1 = Max(2 * a - b, 2 * b - a); // Обчислити компоненти рівняння
            int max2 = Max(a, b);
            // Розрахунок кінцевого результату
            int y = max1 + max2;  //Розраху кінцевий результат
            // Виведення результату
            Console.WriteLine($"Значення y дорiвнює: {y}");
        }
    }
}
*/
/*
namespace lab6_task2
{
    internal class Program
    {
        static void Main()
        {
            Console.Write("Введiть x: "); // Введення вхідних параметрів x і t
            double x = double.Parse(Console.ReadLine());
            Console.Write("Введiть t: ");
            double t = double.Parse(Console.ReadLine());
            double b = Math.Pow(Math.Log10(Math.Abs(x)), 2); // Обчислення b
            double a = Math.Pow(t, 3) + Math.Sqrt(b); // Обчислення a
            double y = Math.Pow(Math.Sin(a + b), 3); // Обчислення y
            Console.WriteLine($"Результат y: {y}"); // Виведення результату
        }
    }
}
*/
/*
namespace lab6_task3
{
    internal class Program
    {
        static void Main()
        {
            const int rows = 5;
            const int cols = 7;
            int[,] matrix = new int[rows, cols]; // Створення матриці
            FillMatrix(matrix); // Виклик функцій користувача
            Console.WriteLine("Згенерована матриця:");
            PrintMatrix(matrix);
            (int maxRow, int maxValue) = ProcessMatrix(matrix);
            Console.WriteLine($"Номер рядка з найбшльшим за модулем дшагональним елементом: {maxRow + 1}");
            Console.WriteLine($"Значення цього елемента: {maxValue}");
        }
        static void FillMatrix(int[,] matrix) // a. Функція для заповнення матриці випадковими числами
        {
            Random random = new Random();
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    matrix[i, j] = random.Next(0, 101); // Випадкові числа від 0 до 100
                }
            }
        }
        static void PrintMatrix(int[,] matrix)   // b. Функція для виведення матриці в консоль
        {
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    Console.Write(matrix[i, j] + "\t");
                }
                Console.WriteLine();
            }
        }
        static (int maxRow, int maxValue) ProcessMatrix(int[,] matrix) // c. Функція для обробки матриці
        {
            int maxRow = -1;
            int maxValue = int.MinValue;
            for (int i = 0; i < Math.Min(matrix.GetLength(0), matrix.GetLength(1)); i++)
            {
                int diagonalValue = Math.Abs(matrix[i, i]);
                if (diagonalValue > maxValue)
                {
                    maxValue = diagonalValue;
                    maxRow = i;
                }
            }
            return (maxRow, maxValue);
        }
    }
}
*/

namespace lab6_task4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введiть перше число:");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine("Введiть друге число:");
            int b = int.Parse(Console.ReadLine());
            int gcd = FindGCD(a, b);
            Console.WriteLine($"Найбiльший спiльний дiльник чисел {a} i {b} дорiвнює {gcd}");
        }
        static int FindGCD(int a, int b)
        {
            if (b == 0) // Якщо одне з чисел дорівнює 0, повертаємо інше число
                return a;
            return FindGCD(b, a % b); // Рекурсивний виклик функції з аргументами b і залишком від ділення a на b
        }
    }
}