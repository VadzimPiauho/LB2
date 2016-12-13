using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace case_5
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] B = new int[5, 5];
            int sumB = 0, max=B[0,0],min = B[0, 0];
            int ni = 0, mj = 0, ki = 0, lj = 0;
            Random rand = new Random();
            try
            {
                //double x = Math.Round(rand.NextDouble(),2)+rand.Next(100);
                Console.WriteLine("Заполнение массива А");

                Console.WriteLine("Массив B");

                for (int i = 0; i < B.GetLength(0); i++)
                {
                    for (int j = 0; j < B.GetLength(1); j++)
                    {
                        B[i, j] = rand.Next(-100,100);
                        if (max < B[i,j])
                        {
                            max = B[i, j];
                            ni = i;
                            mj = j;
                        }
                        if (min > B[i, j])
                        {
                            min = B[i, j];
                            ki = i;
                            lj = j;
                        }
                        Console.Write($"{B[i, j]}" + "\t");
                    }
                    Console.WriteLine();
                }
                
                //for (int i = 0; i < B.GetLength(0); i++)
                //{
                //    for (int j = 0; j < B.GetLength(1); j++)
                //    {
                        
                //        if (B[i, j]==max)
                //        {
                //            ni = i;
                //            mj = j;
                //        }
                //        if (B[i, j] == min)
                //        {
                //            ki = i;
                //            lj = j;
                //        }
                //    }
                //    Console.WriteLine();
                //}
                Console.WriteLine();
               

                Console.WriteLine("Максимальный элемент массива B = " + max);
                Console.WriteLine("Минимальный элемент массива B = " + min);

                Console.WriteLine($"Максимальный элемент {B.Cast<int>().Max()}  находится в массиве на {ni} {mj} позиции");
                Console.WriteLine($"Максимальный элемент {B.Cast<int>().Min()} находится в массиве на {ki} {lj} позиции");

                Console.WriteLine("Cуммa элементов массива, расположенных между минимальным и максимальным элементами = " + sumB);
            }
            catch (Exception)
            {
                Console.WriteLine("Завершение программы");
                Environment.Exit(0);
            }
        }
    }
}
