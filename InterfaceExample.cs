using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackerRankInterfaceExample
{
    class InterfaceExample
    {
        //Write the Calculator class, which implements the AdvancedArithmetic interface.
        //The implementation for the divisorSum method must be public and take an integer parameter,n , and return the sum of all its divisors.
        static void Main(string[] args)
        {
            int n = Int32.Parse(Console.ReadLine());
            IAdvancedArithmetic myCalculator = new Calculator();
            int sum = myCalculator.DivisorSum(n);
            Console.WriteLine("I implemented: AdvancedArithmetic\n" + sum);
        }
    }

    public interface IAdvancedArithmetic
    {
        int DivisorSum(int n);
    }

    class Calculator : IAdvancedArithmetic
    {
        public int DivisorSum(int n)
        {
            int iDivisorSum = 1 + n;
            List<int> lDivisorList = new List<int>();
            for (int i = 2; i < n / 2; i++)
            {
                if (!lDivisorList.Exists(num => num == i))
                {
                    switch (n % i)
                    {
                        case 0:
                            iDivisorSum += i; // Add the number to the sum
                            lDivisorList.Add(i);//Add the number to the list
                            int iQuotient = n / i; //Calculate the quotion
                            if (i != iQuotient)//Handles the case for squares
                            {
                                iDivisorSum += iQuotient;//add the quotient to sume
                                lDivisorList.Add(iQuotient);//add the quotient to the list to reuduce iteraions
                            }
                            break;
                        default:
                            break;
                    }
                }
            }
            return iDivisorSum;
        }
    }
}
