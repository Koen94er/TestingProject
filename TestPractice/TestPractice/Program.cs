﻿using System;

namespace RectangleApp
{
    public class Rectangle
    {
        double length;
        double width;
        public void AcceptDetail()
        {
            length = 8;
            width = 2.5;
        }
        public double GetArea()
        {
            return length * width;
            
        }
        public void Display()
        {
            Console.WriteLine("Length: {0}", length);
            Console.WriteLine("Width: {0}", width);
            Console.WriteLine("Area: {0}", GetArea());
        }
    }
    public class ExecuteRectangle
    {
        static void Main(string[] args)
        {
            //test
            Rectangle r = new Rectangle();
            r.AcceptDetail();
            r.Display();
            Console.ReadLine();
        }
    }
}
