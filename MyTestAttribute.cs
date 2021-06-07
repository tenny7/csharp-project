using System;
namespace csharpconsole
{
    [AttributeUsageAttribute(AttributeTargets.Class | AttributeTargets.Struct)]
    public class MyTestAttribute : Attribute
    {
        public MyTestAttribute(string fname)
        {

        }
    }
}