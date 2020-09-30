using System;
using System.Collections.Generic;
using System.Text;

namespace _21_Singleton
{
    class Singleton
    {
        private static Singleton instance = null;

        protected Singleton()
        {

        }

        public static Singleton Instance()
        {
            if (instance == null)
            {
                instance = new Singleton();
            }
            return instance;
        } 
    }
}
