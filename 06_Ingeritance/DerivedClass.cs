namespace _06_Inheritance
{
    internal class DerivedClass : BaseClass
    {
        public string publicField2 = "DerivedClass.field2";

        public DerivedClass()
        {
            publicField = "DerivedClass.publicField";

            protectedField = "DerivedClass.protectedField";
        }
    }
}