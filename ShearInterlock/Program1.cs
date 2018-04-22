using System;


namespace UnitConversion
{
    class Program
    {
        static void Main(string[] args)
        {
            Parameter p1 = new Parameter("Test Param", DisplayUnit.PASCAL, UnitType.STRESS);

            while (true)
            {

                Console.Write("Enter a stress value in pa: ");

                string s1 = Console.ReadLine();

                bool success = p1.SetValue(s1);

                if (success)
                {
                    Console.WriteLine("Value set to:" + p1.Value);
                    Console.WriteLine("Value String Returned:" + p1.GetValueString());
                }
                else
                {
                    Console.WriteLine("Failed to set Param Value");
                }

                
            }

            Console.ReadLine();
        }
    }
}
