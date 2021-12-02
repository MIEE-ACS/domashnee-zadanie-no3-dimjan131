using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TaskCSCH
{
    class Program
    {
        //окружность
        static double Segment1(double x, double r)
        {
            return 2 - Math.Sqrt(r*r - Math.Pow(x + 8, 2));
        }

        //y=k*x+b
        static double Segment234(double x, double k, double b)
        {
            return k * x + b;
        }

        static void Main(string[] args)
        {
            Console.Write("Введите R: ");
            double r = double.Parse(Console.ReadLine());
            for(double x=-11; x<=5; x=x+0.5)
            {
                if(x>=-10 && x>=-8-r && x<=-8+r)
                    Console.WriteLine("y({0:0.00}) = {1:0.00}", x, Segment1(x, r));
                else if(x>=-6 && x<=-4)
                    Console.WriteLine("y({0:0.00}) = {1:0.00}", x, Segment234(x, 0, 2));
                else if (x >-4 && x <= 2)
                    Console.WriteLine("y({0:0.00}) = {1:0.00}", x, Segment234(x, -0.5, 0));
                else if (x > 2 && x <= 4)
                    Console.WriteLine("y({0:0.00}) = {1:0.00}", x, Segment234(x, 1, -3));
                else
                    Console.WriteLine("y({0:0.00}) = {1}", x, "Не определенно");
            }
            
            Console.ReadLine();
        }
    }
}
