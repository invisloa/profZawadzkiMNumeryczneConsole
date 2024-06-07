using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace profZawadzkiMNumeryczneConsole
{
    internal class MetodaNewtona
    {
        public static double ZnajdzMiejsceZerowe(string f, double poczatkoweZgadniecie, int n)
        {
            double x = poczatkoweZgadniecie;

            for (int i = 0; i < n; i++)
            {
                double fValue = Funkcja(f, x);
                double dfValue = Pochodna(f, x);
                if (dfValue == 0)
                {
                    throw new Exception("Pochodna wynosi zero w tym punkcie, metoda Newtona zawodzi.");
                }
                x -= fValue / dfValue;
            }

            return x;
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

        private static double Pochodna(string f, double x)
        {
            switch (f)
            {
                case "sinx":
                    return Math.Cos(x);
                case "5*x^5-2*x^4+2*x-10":
                    return 25 * Math.Pow(x, 4) - 8 * Math.Pow(x, 3) + 2;
                default:
                    throw new ArgumentException("Funkcja nieobsługiwana.");
            }
        }

    }
}
