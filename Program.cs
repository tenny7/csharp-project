using System;

namespace csharpconsole
{
    [MyTest("Tennyson")]
    class Program : Employee, IFullname
    {
        public void Name(string fname, string lname)
        {
            Console.WriteLine("{0} and {1}",fname,lname);
        }
        static void Main(string[] args)
        {
            Employee emp = new Employee();
            string fname, lname, email;
            Console.WriteLine("Enter FirstName");
            fname = Console.ReadLine();

            Console.WriteLine("Enter LastName");
            lname = Console.ReadLine();

            
            email = emp.createEmail(fname.ToLower(),lname.ToLower());
            Console.WriteLine("Employee generated email is {0}",email);

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
