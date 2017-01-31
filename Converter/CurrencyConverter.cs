using System;
namespace Converter
{
	public class CurrencyConverter
	{

		string input;


		public CurrencyConverter(string _input)
		{
			
			input = _input;

		}

		public string ConvertCurrency()
		{

			var output = "";

			if (input.Length < 1)
			{

				output = "Please enter something";
			}
			else {
				try
				{
					var resultEuro = Convert.ToDouble(input) * 8.9;
					output = input + " € = " + resultEuro + " sek";
				}

				catch (Exception e)
				{
					output = "Please enter a number";
					output = "";
					Console.WriteLine("Error!" + e.Message);
				}
			}
			return output;
		}
	}
}

