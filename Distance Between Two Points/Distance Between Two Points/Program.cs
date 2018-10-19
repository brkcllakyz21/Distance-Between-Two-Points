using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Distance_Between_Two_Points
{
    class Program
    {
        static void Main(string[] args)
        {

            int x_1 = 0, x_2 = 0, y_1 = 0, y_2 = 0;


            Console.WriteLine("1. noktanın x koordinatını giriniz.");
            x_1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("1. noktanın y koordinatını giriniz.");
            y_1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("2. noktanın x koordinatını giriniz.");
            x_2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("2. noktanın y koordinatını giriniz.");
            y_2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("(" + x_1 + "," + y_1 + ") ile " + "(" + x_2 + "," + y_2 + ") noktaları arasındaki uzaklık = " + Math.Pow((Math.Pow(x_1 - x_2, 2)) + (Math.Pow(y_1 - y_2, 2)), 0.5));


        }
    }
}
