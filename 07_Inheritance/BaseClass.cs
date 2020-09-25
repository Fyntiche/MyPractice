using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Text;

namespace _07_Inheritance
{
    class BaseClass
    {
        public string publicField = "BaseClass.publicField";

        private string privateField = "BaseClass.privateField";

        protected string protectedField = "BaseClass.protectedField";

        public void Show()
        {
            Console.WriteLine(privateField);
        }
    }
}
