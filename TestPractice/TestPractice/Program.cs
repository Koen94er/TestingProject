using System;

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
    //public class ExecuteRectangle
    //{
    //    static voi(string[] args)
    //    {
    //        //test
    //        Rectangle r = new Rectangle();
    //        r.AcceptDetail();
    //        r.Display();
    //        Console.ReadLine();
        //}
    public class Program123
    {
        static void Main(string[] args)
        {

            /* 局部变量定义 */
            int a = 100;

            /* 检查布尔条件 */
            if (a < 20)
            {
                /* 如果条件为真，则输出下面的语句 */
                Console.WriteLine("a 小于 20");
            }
            else
            {
                /* 如果条件为假，则输出下面的语句 */
                Console.WriteLine("a 大于 20");
            }
            Console.WriteLine("a 的值是 {0}", a);
            Console.ReadLine();
        }
    }
}
