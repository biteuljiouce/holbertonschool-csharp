using System;

class Program
{
	static void Main(string[] args)
	{
		double percent = .7553;
		double currency = 98765.4321;
        System.Globalization.CultureInfo provider = new System.Globalization.CultureInfo("en-US.utf-8");
		Console.WriteLine("Percent: {0:0.00%}\nCurrency: {1}", percent, currency.ToString("C", provider));
	}
}
// 		Console.WriteLine("Percent: {0:0.00%}\nCurrency: {1}", percent, currency.ToString("C", System.Globalization.CultureInfo.CreateSpecificCulture("en-US.utf-8")));
