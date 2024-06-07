using System;

namespace profZawadzkiMNumeryczneConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            double x0 = 30 * Math.PI / 180; // Convert 30 degrees to radians
            double h1 = 0.1, h2 = 0.01, h3 = 0.001;
            double[] hArray = new double[3] { h1, h2, h3 };
            int n1 = 10, n2 = 100, n3 = 1000;
            int[] nArray = new int[3] { n1, n2, n3 };
            double a = 0, b = Math.PI / (Math.PI / 2);
            Console.WriteLine("Pochodna obliczana Analitycznie:");
            Console.WriteLine($"sin(60) = cos(30) = {Math.Cos(x0)}");
            printSpace();
            // Using Newton's Method
            double zero = MetodaNewtona.ZnajdzMiejsceZerowe("sinx", 3, 100);
            Console.WriteLine($"Miejsce zerowe funkcji sinx znalezione metodą Newtona: {zero}");
            zero = MetodaNewtona.ZnajdzMiejsceZerowe("5*x^5-2*x^4+2*x-10", 3, 100);
            Console.WriteLine($"Miejsce zerowe funkcji  (5 * x ^ 5 - 2 * x ^ 4 + 2 * x - 10) znalezione metodą Newtona: {zero}");
            printSpace();

            // Using Lagrange Interpolator
            double[] xs = { 0, 1, 2, 3 };
            double[] ys = { 1, 2, 0, 4 };
            double interpolatedValue = MetodaLagrange.Interpoluj(xs, ys, 2.5);
            Console.WriteLine($"Wartość interpolowana dla x = 2.5: {interpolatedValue}");
            printSpace();

            // Using MetodaTrapezowa
            MetodaTrapezowa metodaTrapezowa = new MetodaTrapezowa();
            metodaTrapezowa.CalculateAndPrint("sin", a, b, n1);
            printSpace();

            // Using MetodaProstokatow
            double midpointResult = MetodaProstokatow.MidpointRule("sin", a, b, n1);
            Console.WriteLine($"\nCałkowanie numeryczne metodą prostokątów (midpoint) dla n = {n1}, wynik = {midpointResult}");
            printSpace();

            double trapezoidalResult = MetodaProstokatow.TrapezoidalRule("sin", a, b, n1);
            Console.WriteLine($"Całkowanie numeryczne metodą prostokątów (trapezoidal) dla n = {n1}, wynik = {trapezoidalResult}");
            printSpace();

            // Using MetodaKwadratowa
            foreach (double h in hArray)
            {
                MetodaKwadratowa.CalculateAndPrint("sin", x0, h);
            }
            printSpace();
            // Using BiSection
            double bisekcjaResult = BiSection.Bisekcja("sinx", 3, 4, 100);
            Console.WriteLine($"\nMiejsce zerowe funkcji sinx znalezione metodą bisekcji: {bisekcjaResult}");

            printSpace();
            foreach (int n in nArray)
            {
                double simpsonResult = MetodaSimsona.SimpsonRule("sin", a, b, n);
                Console.WriteLine($"\nCałkowanie numeryczne metodą Simpsona dla n = {n}, wynik = {simpsonResult}");
            }
        }
        private static void printSpace()
        {
            Console.WriteLine();
            Console.WriteLine("xxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxx");
            Console.WriteLine();
        }
    }

}