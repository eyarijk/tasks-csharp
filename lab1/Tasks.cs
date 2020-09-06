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

            double a = y + (x / (Math.Pow(y, 2) + Math.Abs(Math.Pow(x, 2) / (y + Math.Pow(x, 3) / 3))));

            double b = 1 + Math.Pow(Math.Tan(z / 2), 2);

            Console.WriteLine("a = " + a);
            Console.WriteLine("b = " + b);
        }

        public void Task11_5()
        {
            Console.WriteLine("Enter x");
            double x = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Enter y");
            double y = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Enter z");
            double z = Convert.ToDouble(Console.ReadLine());

            double a = (2 * Math.Cos(x - Math.PI / 6) / (1 / 2 + Math.Pow(Math.Sin(y), 2)));

            double b = 1 + (Math.Pow(z, 2) / (3 + Math.Pow(z, 2) / 5));

            Console.WriteLine("a = " + a);
            Console.WriteLine("b = " + b);
        }

        public void Task11_6()
        {
            Console.WriteLine("Enter x");
            double x = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Enter y");
            double y = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Enter z");
            double z = Convert.ToDouble(Console.ReadLine());

            double a = (1 + Math.Pow(Math.Sin(x + y), 2)) /
                (2 + Math.Abs(x - 2 * x / (1 + Math.Pow(x, 2) * Math.Pow(y, 2))))
            ;

            double b = Math.Pow(Math.Cos(Math.Atan(1 / z)), 2);

            Console.WriteLine("a = " + a);
            Console.WriteLine("b = " + b);
        }

        public void Task11_7()
        {
            Console.WriteLine("Enter x");
            double x = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Enter y");
            double y = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Enter z");
            double z = Convert.ToDouble(Console.ReadLine());

            double a = Math.Log10((y - Math.Sqrt(Math.Abs(x))) * (x - (y / (z + Math.Pow(x,2) / 4))));

            double b = x - Math.Pow(x, 2) / this.Factorial(3) + Math.Pow(x, 5) / this.Factorial(5);

            Console.WriteLine("a = " + a);
            Console.WriteLine("b = " + b);
        }

        public void Task12()
        {
            Console.WriteLine("Enter a");
            double a = Convert.ToDouble(Console.ReadLine());

            double S = Math.Sqrt(3) / 4 * Math.Pow(a, 2);

            Console.WriteLine("S = " + S);
        }

        public void Task13()
        {
            Console.WriteLine("Enter l");
            double l = Convert.ToDouble(Console.ReadLine());

            double T = 2 * Math.PI * Math.Sqrt(l / 9.8);

            Console.WriteLine("T = " + T);
        }

        public void Task14()
        {
            Console.WriteLine("Enter m1");
            double m1 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Enter m2");
            double m2 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Enter r");
            double r = Convert.ToDouble(Console.ReadLine());

            double g = 6.61 * Math.Pow(10, -11);

            double result = g * m1 * m2 / Math.Pow(r, 2);

            Console.WriteLine("result = " + result);
        }

        public void Task15()
        {
            Console.WriteLine("Enter g");
            double g = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Enter k");
            double k1 = Convert.ToDouble(Console.ReadLine());

            double k2 = Math.Sqrt(g * g - k1 * k1);
            double r = (k1 + k2 - g) / 2;

            Console.WriteLine("k2 = " + k2);
            Console.WriteLine("r = " + r);
        }

        public void Task16()
        {
            Console.WriteLine("Enter l");
            double l = Convert.ToDouble(Console.ReadLine());

            double r = l / (2 * Math.PI);
            double s = Math.PI * Math.Pow(r, 2);

            Console.WriteLine("r = " + r);
            Console.WriteLine("s = " + s);
        }

        public void Task17()
        {
            double r1 = 20;

            Console.WriteLine("Enter r2");
            double r2 = Convert.ToDouble(Console.ReadLine());

            double s1 = Math.PI * r1 * r1;
            double s2 = Math.PI * r2 * r2;

            double s = s2 - s1;

            Console.WriteLine("s = " + s);
        }

        public void Task18()
        {
            Console.WriteLine("Enter a");
            double a = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Enter b");
            double b = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Enter r");
            double r = Convert.ToDouble(Console.ReadLine());

            double c = 180 - (a + b);

            double aWidth = 2 * r * Math.Sin(a);
            double bWidth = 2 * r * Math.Sin(b);
            double cWidth = 2 * r * Math.Sin(c);

            Console.WriteLine("aWidth = " + aWidth);
            Console.WriteLine("bWidth = " + bWidth);
            Console.WriteLine("cWidth = " + cWidth);
        }

        public void Task19()
        {
            Console.WriteLine("Enter v1");
            double v1 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Enter a1");
            double a1 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Enter v2");
            double v2 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Enter a1");
            double a2 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Enter width");
            double s = Convert.ToDouble(Console.ReadLine());

            double result = (-(v1 + v2) + Math.Sqrt(Math.Pow(v1 + v2, 2) + 2 * (a1 + a2) * s)) / (a1 + a2);

            Console.WriteLine("result = " + result);
        }

        public void Task20()
        {
            Console.WriteLine("Enter a");
            double a = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Enter d");
            double d = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Enter n");
            double n = Convert.ToDouble(Console.ReadLine());

            double sum = 0;

            for (int i = 1; i < n; i++)
            {
                sum += a + ((i - 1) * d);
            }

            Console.WriteLine("sum sum = " + sum); ;
        }

        public void Task21()
        {
            Console.WriteLine("Enter c");
            double c = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Enter d");
            double d = Convert.ToDouble(Console.ReadLine());

            double D = (-3 * -3) - 4 * 1 * Math.Abs(c * d);

            if (D < 0)
            {
                Console.WriteLine("D < 0");
                return;
            }

            double x1 = (3 + Math.Sqrt(D)) / 2;
            double x2 = (3 - Math.Sqrt(D)) / 2;
            double a = Math.Abs(Math.Pow(Math.Sin(Math.Abs(c * Math.Pow(x1, 3) + d * (x2 * x2) - c * d)), 3) / (Math.Sqrt(((c * Math.Pow(x1, 3) + d * (x2 * x2) - x1) * (c * Math.Pow(x1, 3) + d * (x2 * x2) - x1)) + 3.14))) + Math.Tan(c * Math.Pow(x1, 3) + d * (x2 * x2) - x1);

            Console.Write("result = " + a);
        }

        public void Task22()
        {
            Console.WriteLine("Enter a");
            double a = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Enter b");
            double b = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Enter degree");
            double degree = Convert.ToDouble(Console.ReadLine());

            double u = degree * Math.PI / 180;
            double h = (a - b) * Math.Sin(u) / (2 * Math.Cos(u));
            double s = (a + b) * h / 2;

            Console.Write("s = " + s);
        }

        public void Task23()
        {
            Console.WriteLine("Enter a");
            double a = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Enter b");
            double b = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Enter c");
            double c = Convert.ToDouble(Console.ReadLine());

            double p = (a + b + c) / 2;
            double _h = Math.Sqrt(p * (p - a) * (p - b) * (p - c));
            double ha = 2 * _h / a;
            double hb = 2 * _h / b;
            double hc = 2 * _h / c;

            double ma = (Math.Sqrt(2 * b * b + 2 * c * c - a * a)) / 2;
            double mb = (Math.Sqrt(2 * a * a + 2 * c * c - b * b)) / 2;
            double mc = (Math.Sqrt(2 * a * a + 2 * b * b - c * c)) / 2;

            double R_op = (a * b * c) / (4 * _h);
            double R_vp = Math.Sqrt(((p - a) * (p - b) * (p - c)) / p);
            double L = (2 * Math.Sqrt(a * b * p * (p - c))) / (a + b);

            Console.Write("ha = " + ha);
            Console.Write("hb = " + hb);
            Console.Write("hc = " + hc);

            Console.Write("ma = " + ma);
            Console.Write("mb = " + mb);
            Console.Write("mc = " + mc);

            Console.Write("R_op = " + R_op);
            Console.Write("R_vp = " + R_vp);
            Console.Write("L = " + L);
        }

        public void Task24()
        {
            Console.WriteLine("Enter x1");
            double x1 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Enter y1");
            double y1 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Enter x2");
            double x2 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Enter y2");
            double y2 = Convert.ToDouble(Console.ReadLine());

            double d = Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2));

            Console.Write("d = " + d);
        }

        public void Task25()
        {
            Console.WriteLine("Enter ax1");
            double x1 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Enter ay1");
            double y1 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Enter bx1");
            double x2 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Enter by1");
            double y2 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Enter cx1");
            double x3 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Enter cy1");
            double y3 = Convert.ToDouble(Console.ReadLine());

            double st1 = Math.Sqrt(Math.Pow(x1 - x2, 2) + Math.Pow(y1 - y2, 2));
            double st2 = Math.Sqrt(Math.Pow(x2 - x3, 2) + Math.Pow(y2 - y3, 2));
            double st3 = Math.Sqrt(Math.Pow(x3 - x1, 2) + Math.Pow(y3 - y1, 2));

            double p = st1 + st2 + st3;
            double pp = p / 2;
            double s = Math.Sqrt(pp * (pp - st1) * (pp - st2) * (pp - st3));

            Console.Write("p = " + p);
            Console.Write("s = " + s);
        }

        public void Task26()
        {
            double r = 13.7f;

            Console.WriteLine("Enter Radians");
            double radians = Convert.ToDouble(Console.ReadLine());

            double result = r * r * radians / 2;

            Console.Write("result = " + result);
        }

        public void Task27()
        {
            Console.WriteLine("Enter a");
            double a = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Enter b");
            double b = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Enter c");
            double c = Convert.ToDouble(Console.ReadLine());

            if ((a + b <= c) || (a + c <= b) || (b + c <= a))
            {
                Console.WriteLine("треугольник с такими сторонами не существует");
                return;
            }

            double alpha = Math.Acos((Math.Pow(b, 2) + Math.Pow(c, 2) - Math.Pow(a, 2)) / (2 * b * c)) * 180 / Math.PI;
            double beta = Math.Acos((Math.Pow(a, 2) + Math.Pow(c, 2) - Math.Pow(b, 2)) / (2 * a * c)) * 180 / Math.PI;
            double gamma = 180 - alpha - beta;

            Console.Write("alpha = " + alpha);
            Console.Write("beta = " + beta);
            Console.Write("gamma = " + gamma);
        }

        public void Task28()
        {
            Console.WriteLine("Enter x");
            double x = Convert.ToDouble(Console.ReadLine());

            double a = 2 * x * x * (x * x + 2) - x * (3 * x * x - 5) + 6;

            Console.Write("a = " + a);
        }

        public void Task29()
        {
            Console.WriteLine("Enter x");
            double x = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Enter x");
            double y = Convert.ToDouble(Console.ReadLine());

            double a = 3 * Math.Pow(x, 2) * Math.Pow(y, 2) - (2 * x) * Math.Pow(y, 2) - (7 * Math.Pow(x, 2) * y) - 4 * Math.Pow(y, 2) + 15 * x * y + 2 * Math.Pow(x, 3) - 3 * x + 10 * y + 6;

            Console.Write("a = " + a);
        }

        public void Task30()
        {
            Console.WriteLine("Enter x");
            double x = Convert.ToDouble(Console.ReadLine());

            double res1 = 1 - 2 * x + 3 * x * x - 4 * x * x * x;
            double res2 = 1 + 2 * x + 3 * x * x + 4 * x * x * x;

            Console.Write("res1 = " + res1);
            Console.Write("res2 = " + res2);
        }

        public void Task31_1()
        {
            Console.WriteLine("Enter x");
            double x = Convert.ToDouble(Console.ReadLine());

            double a = x * x;
            a *= a;

            Console.Write("a = " + a);
        }

        public void Task31_2()
        {
            Console.WriteLine("Enter x");
            double x = Convert.ToDouble(Console.ReadLine());

            double a = x * x;
            a *= a;
            double b = a * a;

            Console.Write("a = " + a * b);
        }

        public void Task31_3()
        {
            Console.WriteLine("Enter x");
            double x = Convert.ToDouble(Console.ReadLine());

            double b = x * x;
            double c = b * b;
            b = c * b;

            Console.Write("a = " + x * b);
        }

        public void Task31_4()
        {
            Console.WriteLine("Enter x");
            double x = Convert.ToDouble(Console.ReadLine());

            double a = x * x;
            a *= a;
            a *= a;

            Console.Write("a = " + x);
        }

        public void Task32_1()
        {
            Console.WriteLine("Enter x");
            double x = Convert.ToDouble(Console.ReadLine());

            double a2 = x * x;
            double a3 = a2 * x;
            double a5 = a3 * a2;

            Console.Write("a = " + a5 * a5);
        }

        public void Task32_2()
        {
            Console.WriteLine("Enter x");
            double x = Convert.ToDouble(Console.ReadLine());

            double a2 = x * x;
            double a4 = a2 * a2;
            double a8 = a4 * a4;
            double a16 = a8 * a8;

            Console.Write("a = " + a16 * a4);
        }

        public void Task32_3()
        {
            Console.WriteLine("Enter x");
            double x = Convert.ToDouble(Console.ReadLine());

            double a2 = x * x;
            double a4 = a2 * a2;
            double a5 = a2 * x;
            double a9 = a5 * a4;
            double a18 = a9 * a9;

            Console.Write("a = " + a18 * x);
        }

        public void Task32_4()
        {
            Console.WriteLine("Enter x");
            double x = Convert.ToDouble(Console.ReadLine());

            double a2 = x * x;
            double a5 = a2 * x;
            double a10 = a5 * a5;
            double a15 = a10 * a2;

            Console.Write("a = " + a15 * a2);
        }

        public void Task32_5()
        {
            Console.WriteLine("Enter x");
            double x = Convert.ToDouble(Console.ReadLine());

            double a2 = x * x;
            double a4 = a2 * a2;
            double a8 = a4 * a4;
            double a12 = a8 * a4;
            double a24 = a12 * a12;
            double a28 = a24 * a4;

            Console.Write("a = " + a28);
        }


        private int Factorial(int number)
        {
            int result = 1;
            while (number != 1)
            {
                result *= number;
                number--;
            }

            return result;
        }
    }
}
