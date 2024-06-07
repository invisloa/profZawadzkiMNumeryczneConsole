using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace profZawadzkiMNumeryczneConsole
{
    internal class MetodaSimsona
    {
        public static double SimpsonRule(string f, double a, double b, int n)
        {
            if (n % 2 != 0)
            {
                throw new ArgumentException("n must be an even number.");
            }

            double h = (b - a) / n;
            double sum = 0;
            switch (f)
            {
                case "sin":
                    sum = Math.Sin(a) + Math.Sin(b);
                    for (int i = 1; i < n; i += 2)
                    {
                        sum += 4 * Math.Sin(a + i * h);
                    }
                    for (int i = 2; i < n - 1; i += 2)
                    {
                        sum += 2 * Math.Sin(a + i * h);
                    }
                    break;
                case "cos":
                    sum = Math.Cos(a) + Math.Cos(b);
                    for (int i = 1; i < n; i += 2)
                    {
                        sum += 4 * Math.Cos(a + i * h);
                    }
                    for (int i = 2; i < n - 1; i += 2)
                    {
                        sum += 2 * Math.Cos(a + i * h);
                    }
                    break;
                case "tg":
                    sum = Math.Tan(a) + Math.Tan(b);
                    for (int i = 1; i < n; i += 2)
                    {
                        sum += 4 * Math.Tan(a + i * h);
                    }
                    for (int i = 2; i < n - 1; i += 2)
                    {
                        sum += 2 * Math.Tan(a + i * h);
                    }
                    break;
                case "sqrt":
                    sum = Math.Sqrt(a) + Math.Sqrt(b);
                    for (int i = 1; i < n; i += 2)
                    {
                        sum += 4 * Math.Sqrt(a + i * h);
                    }
                    for (int i = 2; i < n - 1; i += 2)
                    {
                        sum += 2 * Math.Sqrt(a + i * h);
                    }
                    break;
                default:
                    throw new ArgumentException("Unsupported function.");
            }

            return sum * (h / 3);
        }
    }
}
