using System;

namespace methods_adkinspeter
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            Console.WriteLine("enter a number");
            float q = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("enter a second number");
            float a = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("for addition enter 1");
            Console.WriteLine("for subtraction enter 2");
            Console.WriteLine("for multiplication enter 3");
            Console.WriteLine("for division enter 4");

            int userchoice = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("result" + method(q, a, userchoice));

        }
        static float method(float q, float a, int userchoice)
        {
            switch (userchoice)
            {
                case 1: return (q + a);
                case 2: return (q - a);
                case 3: return (q * a);
                case 4:
                    {
                        if (a == 0)
                            Console.WriteLine("Try again / by 0 is not an option");
                        else
                            return (q / a);
                        break;
                    
                    }
                default:
                    Console.WriteLine("the valid options are 1-4");
                    break;
            }
            return float.NaN;
        }

}
