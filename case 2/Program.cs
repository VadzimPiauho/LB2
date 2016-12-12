using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace case_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите размерность массива");
           
                Console.WriteLine("Введите М");
                var valueM = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Введите N");
                var valueN = Convert.ToInt32(Console.ReadLine());
                Random rand = new Random();
                int count = 0; 
                 int[] A = new int[valueM];
                 int[] B = new int[valueN];   

            for (int i = 0; i < A.Length; i++)
            {
                A[i] = rand.Next(15);  
            }
            for (int i = 0; i < B.Length; i++)
            {
                B[i] = rand.Next(15);
                for (int j = 0; j < A.Length; j++)
                {
                    if (B[i] == A[j])
                    {
                        count++;
                    }
                }
            }
            PrintArr("Массив A",A);
            PrintArr("Массив B", B);
            if (count!=0)
            {
                int[] AB = new int[count];
                //PrintArr("Массив общий", AB);
                int z = 0;
                for (int i = 0; i < B.Length; i++)
                {
                    for (int j = 0; j < A.Length; j++)
                    {
                        if ((B[i] == A[j]) && (!AB.Contains(B[i])))
                        {
                            AB[z] = B[i];
                            z++;
                        }
                    }
                }
                //PrintArr("Массив общий", AB);
                Array.Resize(ref AB, z);
                PrintArr("Массив общий", AB);
            }
            else
            {
                Console.WriteLine("Общих элементов в массивах нет");
            }
            //Console.WriteLine("Неверный формат ввода размерности массива");
            //Environment.Exit(0);   
          
        }
        static void PrintArr(string text, int[] arr)
        {
             Console.WriteLine(text + ": ");
            for (int A = 0; A < arr.Length; A++)
            {
                Console. Write(arr[A] + "\t"); 
            }
            Console.WriteLine();
        }
    }
}
