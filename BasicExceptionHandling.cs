using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExceptionHandling
{
    class Program
    {
        //Read a string, and print its integer value;
        //if  cannot be converted to an integer, print Bad String.
        static void Main(string[] args)
        {
            string sInputString = Console.ReadLine();
            try
            {
                int iConvertedInt = int.Parse(sInputString);
                Console.Write("{0}", iConvertedInt);
            }
            catch (Exception ex)
            {
                if (ex is FormatException)
                {
                    Console.Write("Bad String");
                }
            }
        }
    }
}
