using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace profZawadzkiMNumeryczneConsole
{
    internal class MetodaLagrange
    {
        public static double Interpoluj(double[] xs, double[] ys, double x)
        {
            double wynik = 0;
            int n = xs.Length;

            for (int i = 0; i < n; i++)
            {
                double term = ys[i];
                for (int j = 0; j < n; j++)
                {
                    if (j != i)
                    {
                        term *= (x - xs[j]) / (xs[i] - xs[j]);
                    }
                }
                wynik += term;
            }

            return wynik;
        }
    }
}