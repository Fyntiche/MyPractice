namespace _21_Singleton
{
    internal class Singleton
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