using System;
using System.Collections.Generic;
using System.Text;

namespace _02_Association
{
    class Factory
    {
        public Product FactoryMethod()
        {
            return new Product();
        }
    }
}
