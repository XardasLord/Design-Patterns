using System;

namespace Singleton
{
    public class Singleton
    {
        private static Singleton _instance = null;
        private static readonly object obj = new object();

        private Singleton()
        {
        }

        public static Singleton GetInstance()
        {
            if (_instance == null)
            {
                lock (obj)
                {
                    _instance = new Singleton();
                }
            }

            return _instance;
        }

        public void DoSomething()
        {
            Console.WriteLine("Singleton instance is writting...");
        }
    }
}
