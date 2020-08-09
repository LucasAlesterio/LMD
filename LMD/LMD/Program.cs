using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LMD
{
    class Program
    {
        static void Main(string[] args)
        {
            //string a, b, c, d, e, f, g, h;
            char[] frase = new char[40];
            char a = new char;
            char[] b = new char[20];

            //string str = new string;
            //int a;
            Console.WriteLine("Digite a operação:");

            frase = Console.ReadLine().ToArray();
            a = frase[0];
            b = frase[2];
            /*
            //Console.WriteLine(frase);
            //Console.ReadLine();
            for(int i; i < frase.Length; i++)
            {
                if (frase[i] == "(")
                {

                }
            }*/
        }
    }
}
