using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _28_sep_2022_class
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string str1 = "get the values";
            string str2 = "to prinnnt";
            Console.WriteLine(str2.Length);


            string str3 = str2.Substring(2, 3);

            string str4 = String.Concat(str1, " ", str2);

            Console.WriteLine(str4);


            char[] chars = str2.ToCharArray();


            foreach (char c in chars)
            {
                Console.WriteLine(c);

            }

            string str5 = str1;
            Console.WriteLine(str5.GetHashCode());
            Console.WriteLine(str1.GetHashCode());
            Console.WriteLine(str2.GetHashCode());

            int a = 5;
            int b = 5;
            Console.WriteLine(a.GetHashCode());
            Console.WriteLine(b.GetHashCode());



            str5.Equals(str1);






        }
    }
}
