﻿using System;
using System.Globalization;

namespace Curso
{
    class Program
    {
        static void Main(string[] args)
        {
            double x = 3.0;
            double y = 4.0;
            double z = -5.0;
            double a, b, c;

            a = Math.Sqrt(x);
            b = Math.Sqrt(y);
            c = Math.Sqrt(25.0);
            Console.WriteLine("Raiz quadrada de " + x + " = " + a);
            Console.WriteLine("Raiz quadrada de " + y + " = " + b);
            Console.WriteLine("Raiz quadrada de 25 = " + c);


            a = Math.Pow(x, y);
            b = Math.Pow(x, 2.0);
            c = Math.Pow(5.0, 2.0);
            Console.WriteLine(x + " elevado a " + y + " = " + a);
            Console.WriteLine(x + " elevado ao quadrado = " + b);
            Console.WriteLine("S elevado ao quadrado = " + c);


            a = Math.Abs(y);
            b = Math.Abs(z);
            Console.WriteLine("Valor absoluto de "+ y + " = " + a);
            Console.WriteLine("Valor absoluto de" + z + " = " + b);

            Console.ReadLine();
        }
    }
}