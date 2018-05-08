using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1.ConsoleCurrencyConvertor
{
    class Program
    {
        static void Main(string[] args)
        {
            var amountToConvert = double.Parse(Console.ReadLine());
            var inputCurrency = Console.ReadLine();
            var OutputCurrency = Console.ReadLine();
            var USDtoBGN = amountToConvert * 1.79549;
            var BGNtoEUR = amountToConvert / 1.95583;
            var EURtoGBP = amountToConvert * 0.771659919;
            var USDtoEUR = amountToConvert * 0.917991;
            if (inputCurrency == "USD")
                if (OutputCurrency == "BGN")
                {
                    Console.WriteLine(Math.Round(USDtoBGN, 2) + " BGN");
                }
            if (inputCurrency == "BGN")
            {
                Console.WriteLine(Math.Round(BGNtoEUR, 2) + " EUR");
            }
            if (inputCurrency == "EUR")
            {
                Console.WriteLine(Math.Round(EURtoGBP, 2) + " GBP");
            }
            if (inputCurrency == "USD")
                if (OutputCurrency == "EUR")
                {
                    Console.WriteLine(Math.Round(USDtoEUR, 2) + " EUR");
                }
        }
    }
}
