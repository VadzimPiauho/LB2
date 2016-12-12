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
            Console.WriteLine("Введите строку для проверки является ли она палиндромом");
            string str = Console.ReadLine();
           //string output= String.Copy(str);
            char[] temp = new char[str.Length];
            int j = 0,countNull=0;
            for (int i = 0; i < str.Length; i++)
            {
                if (str[i] == ' ')
                {
                    countNull++;
                    continue;
                }
                temp[j] = str[i];
                j++;
            }
            Array.Resize(ref temp, str.Length - countNull);
            string output = new string(temp);
            Console.Clear();
            Console.WriteLine(str);
            str = output;
            //Console.WriteLine(str);
            output = new string(output.ToCharArray().Reverse().ToArray());
            //Console.WriteLine(output);
            if (String.Compare(str, output, true) == 0)
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