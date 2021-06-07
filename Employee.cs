using System;

namespace csharpconsole
{
    public class Employee : Features
    {
        public override string createEmail(string fname, string lname){
            string employeeEmail = fname + "." + lname + "@connected.com";
            return employeeEmail;
        }

        public virtual void SaySomething()
        {
           Console.WriteLine("Say something");
        }
    }
}