using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using static System.Net.Mime.MediaTypeNames;

namespace ConsoleApplication14
{
    class Program
    {
        static void Main(string[] args)
        {
            //6
            Console.Write("Введите первую строку: ");
            string string1 = Console.ReadLine();
            Console.Write("Введите вторую строку: ");
            string string2 = Console.ReadLine();
            string string3 = string1 + ' ' + string2;
            string[] str = string3.Split(' ');
            int count = 0;

            for (int i = 0; i < str.Length; i++)
            {
                if (str[i].Contains("da"))
                { count++; }
            }
            Console.WriteLine(count);


            //7
            Console.Write("Введите строку: ");
            string input = Console.ReadLine();
            string[] string4 = input.Split(' ', ',', '.', ':', '!', '?', ';');

            int maxL = 0, index = 0;
            for (int i = 0; i < string4.Length; i++)
            {
                if (string4[i].Length > maxL)
                {
                    maxL = string4[i].Length;
                    index = i;
                }
            }
            string input1 = input.Replace(string4[index], "");
            string output = string4[index] + ' ' + input1;
            Console.Write(output);
            Console.ReadLine();

            //8
            Console.Write("Введите строку: ");
            string input2 = Console.ReadLine();
            int count1 = 0;

            for (int i = 0; i < input2.Length; i++)
            {
                if ((i % 2) != 0)
                { if (input2[i].Equals('y')) { count1++; } }
            }
            Console.WriteLine(count1);

            //9
            Console.Write("Введите строку: ");
            string input3 = Console.ReadLine();
            Console.WriteLine(input3.Replace('a', 'A'));

            //10
            Console.Write("Введите слово: ");
            string input4 = Console.ReadLine();
            int a = input4.Length - 1;
            int b = 0;
            int c = 0;

            for (int i = 0; i < input4.Length; i++)
            {
                if (input4[i] == input4[0])
                { b++; }
                if (input4[i] == input4[a])
                { c++; }
            }

            if (b > c){
                Console.WriteLine("Первая буква встречается в этом слове чаще"); 
                }
            if (b < c) {
                 Console.WriteLine("Последняя буква встречается в этом слове чаще");
                  }
            if (b == c) {
                 Console.WriteLine("Первая и последняя буква встречаются в этом слове одинаково часто"); 
                 }
        }
    }
}