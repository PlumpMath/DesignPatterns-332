using System;

namespace SimpleFactory
{
    class MainClass
    {
        public static void Main (string[] args)
        {
            try {
                Console.WriteLine ("Input NumberA:");
                string InputNumberAStr = Console.ReadLine ();
                Console.WriteLine ("Input Oprator(+ - * /):");
                string InputOper = Console.ReadLine ();
                Console.WriteLine ("Input NumberB:");
                string InputNumberBStr = Console.ReadLine ();

                Operation oper = OperationFactory.createOpration (InputOper);
                oper.NumberA = Convert.ToDouble (InputNumberAStr);
                oper.NumberB = Convert.ToDouble (InputNumberBStr);
                Console.WriteLine (oper.getResult ());
            } catch (Exception ex) {
                Console.WriteLine (ex.Message);

            }
        }
    }
}
