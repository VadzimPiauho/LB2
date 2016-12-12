using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace case_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите строку для проверки явkяется ли она палиндромом");
            string str = Console.ReadLine();
            Console.Clear();
            Console.WriteLine(str);
            string output = new string(str.ToCharArray().Reverse().ToArray());
            Console.WriteLine(output);
            if (str.CompareTo(output) == 0)
            {
                Console.WriteLine("Строка ЯВЛЯЕТСЯ палиндромом");
            }
            else
            {
                Console.WriteLine("Строка НЕ ЯВЛЯЕТСЯ палиндромом");
            }
        }
    }
}