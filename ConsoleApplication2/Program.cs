using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Controller
{
    class Program
    {

        /// <summary>
        /// This class is only intended for testing purposes.
        /// 
        /// My idea to implement this into a API is that the method fb.getFizzBuzzList(); could be called async, being able to give response to diferents calls even if the max value is
        /// absurd big. Due my inexperience with building APIS plus some personal matters i couldn't do more than this. I hope it could show at least how my mind works in order to 
        /// resolve problems.
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            FizzBuzz fb;
            string fbList;

            Console.WriteLine("TESTING ALGORITHM\n");

            int startValue = 0;
            int maxValue = 0;

            if (args.Length == 0)
            {
                bool ok = false;
                Console.Write("Introduce start value (INT): ");
                do
                {
                    ok = int.TryParse(Console.ReadLine(), out startValue);
                    if (startValue < 0) ok = false;
                    if(!ok) Console.Write("Please, introduce a POSITIVE INTEGER: ");
                } while (!ok);

                ok = false;
                Console.Write("Introduce max value (INT): ");
                do
                {
                    ok = int.TryParse(Console.ReadLine(), out maxValue);
                    if (maxValue < 0) ok = false;
                    if (!ok) Console.Write("Please, introduce a POSITIVE INTEGER: ");
                } while (!ok);
            }
            else
            {
                startValue = int.Parse(args[0]);
                maxValue = int.Parse(args[1]);
            }

            fb = new FizzBuzz(startValue, maxValue);
            fbList = fb.getFizzBuzzList();


            Console.WriteLine(fbList);

            Console.ReadLine();

        }
    }
}
