using System;

namespace profZawadzkiMNumeryczneConsole
{
	internal class MetodaTrapezowa
	{


		public void CalculateAndPrint(string f, double a, double b, int n)
		{
			Console.WriteLine("Całkowanie analityczne:");
			Console.WriteLine($"Całka oznaczona z f(x) = sinx, a = {a}, b = {b}, wynosi: {-Math.Cos(b) + Math.Cos(a)}");

			Console.WriteLine("\nCałkowanie numeryczne metodą trapezów:");
			double result1 = Integral1(f, a, b, n);
			Console.WriteLine($"Dla n = {n}, wynik = {result1}");

		}

		public double Integral1(string f, double a, double b, int n)
		{
			double dx = (b - a) / n;
			double value = 0;

			switch (f)
			{
				case "sin":
					value += (Math.Sin(a) + Math.Sin(b)) / 2;
					for (int i = 1; i < n; i++)
					{
						double x = a + i * dx;
						value += Math.Sin(x);
					}
					break;
				case "cos":
					value += (Math.Cos(a) + Math.Cos(b)) / 2;
					for (int i = 1; i < n; i++)
					{
						double x = a + i * dx;
						value += Math.Cos(x);
					}
					break;
				case "tg":
					value += (Math.Tan(a) + Math.Tan(b)) / 2;
					for (int i = 1; i < n; i++)
					{
						double x = a + i * dx;
						value += Math.Tan(x);
					}
					break;
				case "sqrt":
					value += (Math.Sqrt(a) + Math.Sqrt(b)) / 2;
					for (int i = 1; i < n; i++)
					{
						double x = a + i * dx;
						value += Math.Sqrt(x);
					}
					break;
				default: throw new ArgumentException("Unsupported function.");
			}

			return value * dx;
		}

	}
}
