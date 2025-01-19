using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задачи
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите номер задания: ");
            int number;
            switch (Console.ReadLine())
            {
                default:
                case "1":
                    Task1();
                    break;
                case "2":
                    Task2();
                    break;
                case "3":
                    Task3();
                    break;
                case "4":
                    Task3();
                    break;
                case "5":
                    Task3();
                    break;
                case "6":
                    Task3();
                    break;
                case "7":
                    Task3();
                    break;
                case "8":
                    Task3();
                    break;
                case "9":
                    Task3();
                    break;
                case "10":
                    Task3();
                    break;
                case "11":
                    Task3();
                    break;
                case "12":
                    Task3();
                    break;
                case "13":
                    Task3();
                    break;
                case "14":
                    Task3();
                    break;
                case "15":
                    Task3();
                    break;
                case "16":
                    Task3();
                    break;
                case "17":
                    Task3();
                    break;
                case "18":
                    Task3();
                    break;
                case "19":
                    Task3();
                    break;
                case "20":
                    Task3();
                    break;
                case "21":
                    Task3();
                    break;
                case "22":
                    Task3();
                    break;
                case "23":
                    Task3();
                    break;
                case "24":
                    Task3();
                    break;
                case "25":
                    Task3();
                    break;
                case "26":
                    Task3();
                    break;
                case "27":
                    Task3();
                    break;
                case "28":
                    Task3();
                    break;
                case "29":
                    Task3();
                    break;
                case "30":
                    Task3();
                    break;

            }
        }
        public static void Task1()
        {
            Console.WriteLine("Задание №1");
            double R, t, l;

            Console.WriteLine("Введите значение - t");

            t = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Введите значение - l");

            l = Convert.ToDouble(Console.ReadLine());

            R = 3 * Math.Pow(t, 2) + 3 * Math.Pow(l, 5) + 4.9;
            Console.WriteLine($"R = {R}");
        }
        public static void Task2()
        {
            Console.WriteLine("Задание №2");
            double K, y, p, e;

            Console.WriteLine("Введите значение - y");

            y = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Введите значение - p");

            p = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Введите значение - e");

            e = Convert.ToDouble(Console.ReadLine());

            K = Math.Log10(Math.Pow(p, 2) + Math.Pow(y, 3) + Math.Pow(e, p));
            Console.WriteLine($"K = {K}");
        }
        public static void Task3()
        {
            Console.WriteLine("Задание №3");
            double G, n, y;

            Console.WriteLine("Введите значение - n");

            n = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Введите значение - y");

            y = Convert.ToDouble(Console.ReadLine());

            G = n * (y + 3.5) + Math.Sqrt(y);
            Console.WriteLine($"G = {G}");
        }
        public static void Task4()
        {
            Console.WriteLine("Задание №4");
            double D, a, t;

            Console.WriteLine("Введите значение - a");

            a = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Введите значение - t");

            t = Convert.ToDouble(Console.ReadLine());

            D = 9.8 * Math.Pow(a, 2) + 5.52 * Math.Cos(Math.Pow(t, 5));
            Console.WriteLine($"D = {D}");
        }
        public static void Task5()
        {
            Console.WriteLine("Задание №5");
            double L, x;

            Console.WriteLine("введите значение - x");

            x = Convert.ToDouble(Console.ReadLine());

            L = 1.51 * Math.Cos(Math.Pow(x, 2)) + 2 * Math.Pow(x, 3);
            Console.WriteLine($"L = {L}");
        }
        public static void Task6()
        {
            Console.WriteLine("Задание №6");
            double M, y, e, x;

            Console.WriteLine("Введите значение - y");

            y = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Введите значение - e");

            e = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Введите значение - x");

            x = Convert.ToDouble(Console.ReadLine());

            M = Math.Cos(2) * y + 3.6 * Math.Pow(e, x);
            Console.WriteLine($"M = {M}");
        }
        public static void Task7()
        {
            Console.WriteLine("Задание №7");
            double N, m;

            Console.WriteLine("Введите значение - m");

            m = Convert.ToDouble(Console.ReadLine());

            N = Math.Pow(m, 2) + 2.8 * Math.Abs(m) + 0.55;
            Console.WriteLine($"N = {N}");
        }
        public static void Task8()
        {
            Console.WriteLine("Задание №8");
            double T, y;

            Console.WriteLine("Введите значение - y");

            y = Convert.ToDouble(Console.ReadLine());

            T = Math.Sqrt(Math.Abs(6 * Math.Pow(y, 2) - 0.1 * y + 4));
            Console.WriteLine($"T = {T}");
        }
        public static void Task9()
        {
            Console.WriteLine("Задание №9");
            double V, y, x;

            Console.WriteLine("Введите значение - y");

            y = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Введите значение - x");

            x = Convert.ToDouble(Console.ReadLine());

            V = Math.Log10(y + 0.95) + Math.Sin(Math.Pow(x, 4));
            Console.WriteLine($"V = {V}");
        }
        public static void Task10()
        {
            Console.WriteLine("Задание №10");
            double U, e, y, k, x;

            Console.WriteLine("Введите значение - e");

            e = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Введите значение - y");

            y = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Введите значение - k");

            k = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Введите значение - x");

            x = Convert.ToDouble(Console.ReadLine());

            U = Math.Pow(e, y) + 7.355 * Math.Pow(k, 2) + Math.Pow(Math.Sin(x), 2);
            Console.WriteLine($"U = {U}");
        }
        public static void Task11()
        {
            Console.WriteLine("Задание №11");
            double S, y, x;

            Console.WriteLine("Введите значение - y");

            y = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Введите значение - x");

            x = Convert.ToDouble(Console.ReadLine());

            S = 9.756 * Math.Pow(y, 7) + 2 * Math.Tan(x);
            Console.WriteLine($"S = {S}");
        }
        public static void Task12()
        {
            Console.WriteLine("Задание №12");
            double K, t, x;

            Console.WriteLine("Введите значение - t");

            t = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Введите значение - x");

            x = Convert.ToDouble(Console.ReadLine());

            K = 7 * Math.Pow(t, 2) + 3 * Math.Sin(Math.Pow(x, 3)) + 9.2;
            Console.WriteLine($"K = {K}");
        }
        public static void Task13()
        {
            Console.WriteLine("Задание №13");
            double E, y;

            Console.WriteLine("Введите значение - y");

            y = Convert.ToDouble(Console.ReadLine());

            E = Math.Sqrt(Math.Abs(3 * Math.Pow(y, 2) + 0.5 * y + 3));
            Console.WriteLine($"E = {E}");
        }
        public static void Task14()
        {
            Console.WriteLine("Задание №14");
            double R, y, e, x;

            Console.WriteLine("Введите значение - y");

            y = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Введите значение - e");

            e = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Введите значение - x");

            x = Convert.ToDouble(Console.ReadLine());

            R = Math.Abs(Math.Sqrt(Math.Pow(Math.Sin(y), 2) + 6.835 + Math.Pow(e, x)));
            Console.WriteLine($"R = {R}");
        }
        public static void Task15()
        {
            Console.WriteLine("Задание №15");
            double H, y;

            Console.WriteLine("Введите значение - y");

            y = Convert.ToDouble(Console.ReadLine());

            H = Math.Sin(Math.Pow(y, 2)) - 2.8 * y + Math.Sqrt(Math.Abs(y));
            Console.WriteLine($"H = {H}");
        }
        public static void Task16()
        {
            Console.WriteLine("Задание №16");
            double S, y;

            Console.WriteLine("Введите значение - y");

            y = Convert.ToDouble(Console.ReadLine());

            S = Math.Sqrt(Math.Cos(4) * Math.Pow(y, 4) + 7.151);
            Console.WriteLine($"S = {S}");
        }
        public static void Task17()
        {
            Console.WriteLine("Задание №17");
            double N, y;

            Console.WriteLine("Введите значение - y");

            y = Convert.ToDouble(Console.ReadLine());

            N = 3 * Math.Pow(y, 2) + Math.Sqrt(y + 1);
            Console.WriteLine($"N = {N}");
        }
        public static void Task18()
        {
            Console.WriteLine("Задание №18");
            double Z, y;

            Console.WriteLine("Введите значение - y");

            y = Convert.ToDouble(Console.ReadLine());

            Z = 3 * Math.Pow(y, 2) + Math.Sqrt(Math.Pow(y, 3) + 1);
            Console.WriteLine($"Z = {Z}");
        }
        public static void Task19()
        {
            Console.WriteLine("Задание №19");
            double P, n, y, g;

            Console.WriteLine("Введите значение - n");

            n = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Введите значение - y");

            y = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Введите значение - g");

            g = Convert.ToDouble(Console.ReadLine());

            P = n * Math.Sqrt(Math.Pow(y, 3) + 1.09 * g);
            Console.WriteLine($"P = {P}");
        }
        public static void Task20()
        {
            Console.WriteLine("Задание №20");
            double U, e, k, y, x;

            Console.WriteLine("Введите значение - e");

            e = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Введите значение - k");

            k = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Введите значение - y");

            y = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Введите значение - x");

            x = Convert.ToDouble(Console.ReadLine());

            U = Math.Pow(e, k + y) + Math.Tan(x) * Math.Sqrt(y);
            Console.WriteLine($"U = {U}");
        }
        public static void Task21()
        {
            Console.WriteLine("Задание №21");
            double P, e, y, h;

            Console.WriteLine("Введите значение - e");

            e = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Введите значение - y");

            y = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Введите значение - h");

            h = Convert.ToDouble(Console.ReadLine());

            P = Math.Pow(e, y + 5.5) + 9.1 * Math.Pow(h, 3);
            Console.WriteLine($"P = {P}");
        }
        public static void Task22()
        {
            Console.WriteLine("Задание №22");
            double T, u, y, x;

            Console.WriteLine("Введите значение - u");

            u = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Введите значение - y");

            y = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Введите значение - x");

            x = Convert.ToDouble(Console.ReadLine());

            T = Math.Sin(2u) * Math.Log10(2 * Math.Pow(y, 2) + Math.Sqrt(x));
            Console.WriteLine($"T = {T}");
        }
        public static void Task23()
        {
            Console.WriteLine("Задание №23");
            double G, e, y, f;

            Console.WriteLine("Введите значение - e");

            e = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Введите значение - y");

            y = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Введите значение - f");

            f = Convert.ToDouble(Console.ReadLine());

            G = Math.Pow(e, 2 * y) + Math.Sin(f);
            Console.WriteLine($"G = {G}");
        }
        public static void Task24()
        {
            Console.WriteLine("Задание №24");
            double F, y;

            Console.WriteLine("Введите значение - y");

            y = Convert.ToDouble(Console.ReadLine());

            F = 2 * Math.Sin(0.214 * Math.Pow(y, 5) + 1);
            Console.WriteLine($"F = {F}");
        }
        public static void Task25()
        {
            Console.WriteLine("Задание №25");
            double G, e, y, f;

            Console.WriteLine("Введите значение - e");

            e = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Введите значение - y");

            y = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Введите значение - f");

            f = Convert.ToDouble(Console.ReadLine());

            G = Math.Pow(e, 2 * y) + Math.Sin(f);
            Console.WriteLine($"G = {G}");
        }
        public static void Task26()
        {
            Console.WriteLine("задание №26");
            double Z, p;

            Console.WriteLine("Введите значение - p");

            p = Convert.ToDouble(Console.ReadLine());

            Z = Math.Sin(Math.Pow((Math.Pow(p, 2) + 0.4), 3));
            Console.WriteLine($"Z = {Z}");
        }
        public static void Task27()
        {
            Console.WriteLine("Задание №27");
            double W, v, e, y, x;

            Console.WriteLine("Введите значение - v");

            v = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Введите значение - e");

            e = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Введите значение - y");

            y = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Введите значение - x");

            x = Convert.ToDouble(Console.ReadLine());

            W = 1.03 * v + Math.Pow(e, 2 * y) + Math.Tan(x);
            Console.WriteLine($"W = {W}");
        }
        public static void Task28()
        {
            Console.WriteLine("Задание №28");
            double T, e, y, h;

            Console.WriteLine("Введите значение - e");

            e = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Введите значение - y");

            y = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Введите значение - h");

            h = Convert.ToDouble(Console.ReadLine());

            T = Math.Pow(e, y + h) + Math.Sqrt(Math.Abs(6.4 * y));
            Console.WriteLine($"T = {T}");
        }
        public static void Task29()
        {
            Console.WriteLine("Задание №29");
            double N, y;

            Console.WriteLine("Введите значение - y");

            y = Convert.ToDouble(Console.ReadLine());

            N = 3 * Math.Pow(y, 2) + Math.Sqrt(Math.Abs(y + 1));
            Console.WriteLine($"N = {N}");
        }
        public static void Task30()
        {
            Console.WriteLine("Задание №30");
            double W, e, y, r;

            Console.WriteLine("Введите значение - e");

            e = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Введите значение - y");

            y = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("введите значение - r");

            r = Convert.ToDouble(Console.ReadLine());

            W = Math.Pow(e, y + r) + 7.2 * Math.Sin(r);
            Console.WriteLine($"W = {W}");
        }
    }
}
        
    

