using System;

namespace Mediator
{
    class MainClass
    {
        public static void Main (string[] args)
        {
            ConcreteMediator m = new ConcreteMediator ();
            ConcreteColleague1 c1 = new ConcreteColleague1 (m);
            ConcreteColleague2 c2 = new ConcreteColleague2 (m);
            m.C1 = c1;
            m.C2 = c2;

            c1.Send ("Hello c2");
            c2.Send ("Hello c1");

            Console.Read ();
        }
    }
}
