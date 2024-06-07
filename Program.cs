using System;

namespace profZawadzkiMNumeryczneConsole
{
	class Program
	{
		static void Main(string[] args)
		{
			double x0 = 30 * Math.PI / 180; // Convert 30 degrees to radians
			double h1 = 0.1, h2 = 0.01, h3 = 0.001;
			int n1 = 10, n2 = 100, n3 = 1000;
			double a = 0, b = Math.PI/(Math.PI/2);
			Console.WriteLine("Pochodna obliczana Analitycznie:");
			Console.WriteLine($"sin(60) = cos(30) = {Math.Cos(x0)}");

			var result1 = MetodaProstokatow.integrall("sin", a, b, n1);
			var result2 = MetodaProstokatow.integrall("sin", a, b, n2);
			var result3 = MetodaProstokatow.integrall("sin", a, b, n3);
			var result11 = MetodaProstokatow.Integral2("sin", a, b, n1);
			var result22 = MetodaProstokatow.Integral2("sin", a, b, n2);
			var result33 = MetodaProstokatow.Integral2("sin", a, b, n3);


			Console.WriteLine(result1);
			Console.WriteLine(result2);
			Console.WriteLine(result3);
			Console.WriteLine(result11);
			Console.WriteLine(result22);
			Console.WriteLine(result33);

			MetodaTrapezowa metodaTrapezowa = new MetodaTrapezowa();
			metodaTrapezowa.CalculateAndPrint("sin", a, b, n1);
			metodaTrapezowa.CalculateAndPrint("sin", a, b, n2);
			metodaTrapezowa.CalculateAndPrint("sin", a, b, n3);
		}
	}
}
