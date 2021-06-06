using System;

namespace csharpconsole
{
    class Program
    {
        static void Main(string[] args)
        {
            CurrencyConverter currency = new CurrencyConverter();
            int selectedOption;
            int amount;
            double result;
            Console.WriteLine("Select Option!");
            Console.WriteLine("Press 1 to convert to Naira or 2 to convert to pounds");
            selectedOption = Convert.ToInt32(Console.ReadLine());
            switch (selectedOption)
            {
                case 1:
                    Console.WriteLine("Enter amount");
                    amount = Convert.ToInt32(Console.ReadLine());
                    result = currency.FromDollarToNaira(amount);
                    Console.WriteLine("{0} Dollars in Naira is = {1}", amount, result);
                    break;
                case 2:
                    Console.WriteLine("Enter amount");
                    amount = Convert.ToInt32(Console.ReadLine());
                    result = currency.FromDollarToPound(amount);
                    Console.WriteLine("{0} Dollars in Pound is = {1}", amount, result);
                    break;
                default:
                    Console.Write("Please select 1 or 2");
                    break;
            }
        }
    }
}
