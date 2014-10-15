using System;

namespace Singleton
{
    class MainClass
    {
        public static void Main (string[] args)
        {
            SingletonClass s1 = SingletonClass.GetInstance ();
            SingletonClass s2 = SingletonClass.GetInstance ();

            if (s1 == s2)
                Console.WriteLine ("Same Instance!!!");
            Console.Read ();
        }
    }
}
