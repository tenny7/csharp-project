using System;

namespace csharpconsole
{
    class CurrencyConverter
    {
        public const double NairaExchangeRate = 411.50;
        public const double DollarExchangeRate = 0.71;
        public double FromDollarToNaira(int dollar)
        {
            double naira;
            naira = NairaExchangeRate * dollar;
            return naira;
        } 
        public double FromDollarToPound(int dollar)
        {
            double pounds;
            pounds = DollarExchangeRate * dollar;
            return pounds;
        }
    }
}