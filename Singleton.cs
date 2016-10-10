using System;

namespace SingletonPattern.BasicExample
{
    public sealed class Singleton
    {
        //Thread safe implementation

        //the variable is declared to be volatile to ensure that assignment to the instance variable
        //completes before the instance variable can be accessed
        private static volatile Singleton _instance;

        private static object syncRoot = new Object();

        //Constructor is 'private'
        private Singleton()
        {
        }

        public static Singleton Instance()
        {
            //Uses lazy initialization
            if (_instance == null)
            {
                lock (syncRoot)
                {
                    if (_instance == null)
                    {
                        _instance = new Singleton();
                    }
                }
            }

            return _instance;
        }
    }
}