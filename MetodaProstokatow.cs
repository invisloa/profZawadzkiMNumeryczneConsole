using System;

namespace profZawadzkiMNumeryczneConsole
{
	internal class MetodaProstokatow
	{
		public static double integrall(string f, double a, double b, int n)
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
		public static double Integral2(string f, double a, double b, int n)
		{
			double dx = (b - a) / n;
			double value = 0;

			switch (f)
			{
				case "sin":
					for (int i = 1; i < n; i++)
					{
						value += Math.Sin(((a + i * dx) +Math.Sin(a+(i+1)*dx))*dx)/2 ;
					}
					break;
				case "cos":
					value += (Math.Cos(a) + Math.Cos(b)) / 2;
					for (int i = 1; i < n; i++)
					{
						value += Math.Cos(((a + i * dx) + Math.Sin(a + (i + 1) * dx)) * dx) / 2;
					}
					break;
				case "tg":
					value += (Math.Tan(a) + Math.Tan(b)) / 2;
					for (int i = 1; i < n; i++)
					{
						value += Math.Tan(((a + i * dx) + Math.Sin(a + (i + 1) * dx)) * dx) / 2;
					}
					break;
				case "sqrt":
					for (int i = 1; i < n; i++)
					{
						value += Math.Sqrt(((a + i * dx) + Math.Sin(a + (i + 1) * dx)) * dx) / 2;
					}
					break;
				default: throw new ArgumentException("Unsupported function.");
			}

			return value * dx;
		}
	}
}
