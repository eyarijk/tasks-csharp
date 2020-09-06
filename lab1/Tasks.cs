using System;

namespace lab1
{
    public class Tasks
    {
        public void Task1()
        {
            Console.WriteLine("Enter a");

            double a = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Enter b");

            double b = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("+ = " + (a + b));
            Console.WriteLine("- = " + (a - b));
            Console.WriteLine("/ = " + (a / b));
            Console.WriteLine("* = " + (a * b));
        }

        public void Task2()
        {
            Console.WriteLine("Enter x");

            double x = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Enter y");

            double y = Convert.ToDouble(Console.ReadLine());

            double result = (Math.Abs(x) - Math.Abs(y)) / (1 + Math.Abs(x * y));

            Console.WriteLine("Result = " + result);
        }

        public void Task3()
        {
            Console.WriteLine("Enter x");

            double x = Convert.ToDouble(Console.ReadLine());

            double s = Math.Pow(x, 2) * 6;
            double v = Math.Pow(x, 3);

            Console.WriteLine("Result S = " + s);
            Console.WriteLine("Result V = " + v);
        }

        public void Task4()
        {
            Console.WriteLine("Enter x");

            double x = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Enter y");

            double y = Convert.ToDouble(Console.ReadLine());

            double result1 = (x + y) / 2;
            double result2 = Math.Sqrt(x * y);

            Console.WriteLine("Result 1 = " + result1);
            Console.WriteLine("Result 2 = " + result2);
        }

        public void Task5()
        {
            Console.WriteLine("Enter x");

            double x = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Enter y");

            double y = Convert.ToDouble(Console.ReadLine());

            double result1 = (x + y) / 2;
            double result2 = Math.Sqrt(Math.Abs(x * y));

            Console.WriteLine("Result 1 = " + result1);
            Console.WriteLine("Result 2 = " + result2);
        }


        public void Task6()
        {
            Console.WriteLine("Enter k1");
            double k1 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Enter k2");
            double k2 = Convert.ToDouble(Console.ReadLine());

            double s = k1 * k2 / 2;

            double g = Math.Sqrt(Math.Pow(k1, 2) + Math.Pow(k2, 2));

            Console.WriteLine("S = " + s);
            Console.WriteLine("G = " + g);
        }

        public void Task7()
        {
            Console.WriteLine("Enter v1");
            double v1 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Enter t1");
            double t1 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Enter v2");
            double v2 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Enter t2");
            double t2 = Convert.ToDouble(Console.ReadLine());

            double V = v1 + v2;
            double T = (v1 * t1 + v2 * t2) / V;

            Console.WriteLine("V = " + V);
            Console.WriteLine("T = " + T);
        }

        public void Task8()
        {
            Console.WriteLine("Enter n");
            double n = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Enter r");
            double r = Convert.ToDouble(Console.ReadLine());

            double result = 2 * n * r * Math.Sin(Math.PI / n);

            Console.WriteLine("result = " + result);
        }

        public void Task9()
        {
            Console.WriteLine("Enter r1");
            double r1 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Enter r2");
            double r2 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Enter r3");
            double r3 = Convert.ToDouble(Console.ReadLine());

            double r = r1 * r2 * r3 / (r1 * r2 + r1 * r3 + r2 * r3);

            Console.WriteLine("r = " + r);
        }

        public void Task10()
        {
            Console.WriteLine("Enter h");
            double h = Convert.ToDouble(Console.ReadLine());

            double T = Math.Sqrt(2 * h / 9.8);

            Console.WriteLine("T = " + T);
        }

        public void Task11_1()
        {
            Console.WriteLine("Enter x");
            double x = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Enter y");
            double y = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Enter z");
            double z = Convert.ToDouble(Console.ReadLine());

            double a = (Math.Sqrt(Math.Abs(x - 1)) - Math.Pow(Math.Abs(y), 1 / 3)) /
                (1 + (Math.Pow(x, 2) / 2 + (Math.Pow(x, 2) / 4)))
            ;

            double b = x * (Math.Atan(z) * Math.Pow(Math.E, (x + 3) * -1));

            Console.WriteLine("a = " + a);
            Console.WriteLine("b = " + b);
        }

        public void Task11_2()
        {
            Console.WriteLine("Enter x");
            double x = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Enter y");
            double y = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Enter z");
            double z = Convert.ToDouble(Console.ReadLine());

            double a = (3 + Math.Pow(Math.E, y - 1)) /
                (1 + Math.Pow(x, 2) * Math.Abs(y - Math.Tan(z)))
            ;

            double b = 1 + Math.Abs(y - x) +
                (Math.Pow(y - x, 2) / 2) +
                (Math.Pow(Math.Abs(y - x), 3) / 3)
            ;

            Console.WriteLine("a = " + a);
            Console.WriteLine("b = " + b);
        }

        public void Task11_3()
        {
            Console.WriteLine("Enter x");
            double x = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Enter y");
            double y = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Enter z");
            double z = Convert.ToDouble(Console.ReadLine());

            double a = (1 + y) *
                (
                    (x + y / (Math.Pow(x, 2) + 4)) /
                    (Math.Pow(Math.E, x * -1 - 2) + 1 / (Math.Pow(x, 2) + 4))
                )
            ;

            double b = (1 + Math.Cos(y - 2)) /
                (Math.Pow(x, 4) / 2 + Math.Pow(Math.Sin(z), 2))
            ;

            Console.WriteLine("a = " + a);
            Console.WriteLine("b = " + b);
        }

        public void Task11_4()
        {
            Console.WriteLine("Enter x");
            double x = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Enter y");
            double y = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Enter z");
            double z = Convert.ToDouble(Console.ReadLine());

            double a = y + (x / (Math.Pow(y, 2) + Math.Abs(Math.Pow(x, 2) / (y + Math.Pow(x, 3) / 3)))); ;

            double b = (1 + Math.Cos(y - 2)) /
                (Math.Pow(x, 4) / 2 + Math.Pow(Math.Sin(z), 2))
            ;

            Console.WriteLine("a = " + a);
            Console.WriteLine("b = " + b);
        }
    }
}
