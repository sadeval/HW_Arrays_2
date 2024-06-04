using System;

namespace HW_Arrays
{
    internal class CubeAndSphere
    {
        static void Main(string[] args)
        {
            Console.Write("Введите размер куба (n): ");
            int n = Convert.ToInt32(Console.ReadLine());

            // Размер куба m x n x n
            int[,,] cube = new int[n, n, n];

            // Центр и радиус сферы
            int center = n / 2;
            double radius = n / 2.0;

            // Заполнение куба
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    for (int k = 0; k < n; k++)
                    {
                        double distance = Math.Sqrt(Math.Pow(i - center, 2) + Math.Pow(j - center, 2) + Math.Pow(k - center, 2));
                        if (distance <= radius)
                        {
                            cube[i, j, k] = 1;
                        }
                        else
                        {
                            cube[i, j, k] = 0;
                        }
                    }
                }
            }

            // Вывод слоев
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine($"\nСлой {i + 1}:");
                for (int j = 0; j < n; j++)
                {
                    for (int k = 0; k < n; k++)
                    {
                        Console.Write($"{cube[i, j, k]} ");
                    }
                    Console.WriteLine();
                }
            }
        }
    }
}
