using System;

namespace csharpconsole
{
    public class Derived : BaseClass
    {
        public override void SaySomething()
        {
            Console.WriteLine("Something new");
        }
    }
}