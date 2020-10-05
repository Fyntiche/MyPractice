using System;

namespace _07_Inheritance
{
    internal class BaseClass
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