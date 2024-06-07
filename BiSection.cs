using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace profZawadzkiMNumeryczneConsole
{
    internal class BiSection
    {
        public static double Bisekcja(string f, double a, double b, int n)
        {
            double x0 = 0, m = 0;

            if (Funkcja(f, a) * Funkcja(f, b) < 0)
            {
                for (int i = 0; i < n; i++)
                {
                    m = (a + b) / 2;
                    if (Funkcja(f, a) * Funkcja(f, m) < 0)
                    {
                        b = m;
                    }
                    else
                    {
                        a = m;
                    }
                }
                x0 = m;
            }
            return x0;
        }

        public static double Funkcja(string f, double x)
        {
            switch (f)
            {
                case "sinx":
                    return Math.Sin(x);
                case "5*x^5-2*x^4+2*x-10":
                    return 5 * Math.Pow(x, 5) - 2 * Math.Pow(x, 4) + 2 * x - 10;
                default:
                    throw new ArgumentException("Funkcja nieobsługiwana.");
            }
        }

    }
}
