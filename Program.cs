using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Win32;

namespace Ball
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //string h = "Hello";
            //Console.WriteLine("h = {0}", h);
            //Console.ReadLine();
            /*Класс «Шар». Реализовать ввод и вывод полей данных,
            вычисление объема, диаметра и площади поверхности, а также
            вывод информации об объекте.*/
            Ball ball = new Ball();
            double n = ball.InPut("Enter the radius: ");
            double S = ball.S(n);
            double D = ball.D(n);
            double V = ball.Volume(n, D);
            Console.WriteLine("Output of information about the object:\n square: {0}\n diameter: {1}\n volume: {2}", S, D, V);
            Console.ReadLine();
        }
        class Ball
        {
            public double InPut(string message)
            {
                Console.Write(message);
                return Convert.ToDouble(Console.ReadLine());
            }
            public double S(double radius)
            {
                double S = 4 * Math.PI * Math.Pow(radius, 2);
                return S;
            }
            public double D(double radius)
            {
                double D = Math.Pow(radius, 2);
                return D;
            }
            public double Volume(double radius, double D)
            {
                double V = (Math.PI * Math.Pow(D, 3)) / 6;
                return V;
            }
        }
    }
}
