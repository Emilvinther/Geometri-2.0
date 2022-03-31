using System;
using System.Collections.Generic;
using Geometri_2;

namespace Geometri_2._0
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Square square1 = new Square(5);
            Rektangle rektangle1 = new Rektangle(5, 10);
            Trapez trapez1 = new Trapez(10, 9, 8, 9);
            Paralleogram paralleogram1 = new Paralleogram(3, 5, 20);
            Triangle triangle1 = new Triangle(5, 6);

            List<Shape> shapelist = new List<Shape>();

            shapelist.Add(square1);
            shapelist.Add(rektangle1);
            shapelist.Add(trapez1);
            shapelist.Add(paralleogram1);
            shapelist.Add(triangle1);

            foreach (Shape i in shapelist)
            {
                Console.WriteLine("\n");
                Console.WriteLine(i.GetType().Name);
                Console.WriteLine(i.Perimiter());
                Console.WriteLine(i.Area());
            }

            Console.ReadKey();
        }
    }
}
