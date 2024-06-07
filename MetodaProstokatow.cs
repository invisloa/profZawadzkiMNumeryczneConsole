using System;

namespace profZawadzkiMNumeryczneConsole
{
    internal class MetodaProstokatow
    {
        public static double MidpointRule(string f, double a, double b, int n)
        {
            double dx = (b - a) / n;
            double value = 0, x0 = a + dx / 2;

            switch (f)
            {
                case "sin":
                    for (int i = 0; i < n; i++)
                    {
                        value += Math.Sin(x0 + i * dx) * dx;
                    }
                    break;
                case "cos":
                    for (int i = 0; i < n; i++)
                    {
                        value += Math.Cos(x0 + i * dx) * dx;
                    }
                    break;
                case "tg":
                    for (int i = 0; i < n; i++)
                    {
                        value += Math.Tan(x0 + i * dx) * dx;
                    }
                    break;
                case "sqrt":
                    for (int i = 0; i < n; i++)
                    {
                        value += Math.Sqrt(x0 + i * dx) * dx;
                    }
                    break;
                default:
                    throw new ArgumentException("Unsupported function.");
            }

            return value;
        }

        public static double TrapezoidalRule(string f, double a, double b, int n)
        {
            double dx = (b - a) / n;
            double value = 0;

            switch (f)
            {
                case "sin":
                    value += (Math.Sin(a) + Math.Sin(b)) / 2;
                    for (int i = 1; i < n; i++)
                    {
                        value += Math.Sin(a + i * dx);
                    }
                    break;
                case "cos":
                    value += (Math.Cos(a) + Math.Cos(b)) / 2;
                    for (int i = 1; i < n; i++)
                    {
                        value += Math.Cos(a + i * dx);
                    }
                    break;
                case "tg":
                    value += (Math.Tan(a) + Math.Tan(b)) / 2;
                    for (int i = 1; i < n; i++)
                    {
                        value += Math.Tan(a + i * dx);
                    }
                    break;
                case "sqrt":
                    value += (Math.Sqrt(a) + Math.Sqrt(b)) / 2;
                    for (int i = 1; i < n; i++)
                    {
                        value += Math.Sqrt(a + i * dx);
                    }
                    break;
                default:
                    throw new ArgumentException("Unsupported function.");
            }

            return value * dx;
        }
    }
}
