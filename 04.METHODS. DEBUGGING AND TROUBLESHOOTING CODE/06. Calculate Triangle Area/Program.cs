﻿using System;

namespace _06.Calculate_Triangle_Area
{
    class Program
    {
        static void Main(string[] args)
        {
            double width = double.Parse(Console.ReadLine());
            double height = double.Parse(Console.ReadLine());
            double area = TriangleArea(width, height);
            Console.WriteLine(area);
        }

        private static double TriangleArea(double width, double height)
        {
            return (width * height) / 2;
        }
    }
}
