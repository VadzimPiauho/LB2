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
            Console.WriteLine("Введите предложение для подсчета слов");
            string str = Console.ReadLine();
            Console.Clear();
            Console.WriteLine(str);
            string[] strArr = str.Split(" ".ToCharArray(), StringSplitOptions.RemoveEmptyEntries);
            Console.WriteLine("Количество слов в предложении = "+ strArr.Length);  
        }
    }
}