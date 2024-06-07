using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace profZawadzkiMNumeryczneConsole
{
	internal class MetodaKwadratowa
	{
		public static void CalculateAndPrint(string functionName, double x0, double h)
		{
			Console.WriteLine($"Pochodna obliczana Numerycznie dla h={h}, funkcja: {functionName}");
			Console.WriteLine($"Wzór 1: {derivativeOatern1(functionName, x0, h)}");
			Console.WriteLine($"Wzór 2: {derivativePatern2(functionName, x0, h)}");
		}

		static double derivativeOatern1(string f, double x0, double h)
		{
			double value = 0;
			switch (f)
			{
				case "sin":
					value = (Math.Sin(x0 + h) - Math.Sin(x0)) / h;
					break;
				case "cos":
					value = (Math.Cos(x0 + h) - Math.Cos(x0)) / h;
					break;
				case "tg":
					value = (Math.Tan(x0 + h) - Math.Tan(x0)) / h;
					break;
				case "sqrt":
					value = (Math.Sqrt(x0 + h) - Math.Sqrt(x0)) / h;
					break;
				default: value = Double.NaN; break;
			}
			return value;
		}

		static double derivativePatern2(string f, double x0, double h)
		{
			double value = 0;
			switch (f)
			{
				case "sin":
					value = (Math.Sin(x0 + h) - Math.Sin(x0 - h)) / (2 * h);
					break;
				case "cos":
					value = (Math.Cos(x0 + h) - Math.Cos(x0 - h)) / (2 * h);
					break;
				case "tg":
					value = (Math.Tan(x0 + h) - Math.Tan(x0 - h)) / (2 * h);
					break;
				case "sqrt":
					value = (Math.Sqrt(x0 + h) - Math.Sqrt(x0 - h)) / (2 * h);
					break;
				default: value = Double.NaN; break;
			}
			return value;
		}
	}
}
