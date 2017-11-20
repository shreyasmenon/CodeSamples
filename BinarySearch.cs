using System;

namespace BinarySearchAlgo
{
    class BinarySearch
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter the array");
            string[] arrStringInputs = Console.ReadLine().Split(' ');
            int[] arrSortedArray = new int[arrStringInputs.Length];
            arrSortedArray = Array.ConvertAll(arrStringInputs, element => int.Parse(element));
            Array.Sort(arrSortedArray);
            Console.WriteLine("Enter Number to be searched");
            int iNumbertobeSearched = int.Parse(Console.ReadLine());
            Console.WriteLine("{0}", BinarySearchResult(arrSortedArray, iNumbertobeSearched));
            Console.ReadLine();
        }

        public static string BinarySearchResult(int[] arrsortedAray, int numberToBeSarched)
        {
            string sSearchResult = string.Empty;
            float iLeftIndex = 0, iRightIndex = arrsortedAray.Length - 1;
            if (arrsortedAray.Length >= 2)
            {
                while (true)
                {
                    float fMiddleDecimal = (iLeftIndex + iRightIndex) / 2;
                    int iMiddleIndex = Convert.ToInt32((fMiddleDecimal >= 1 ? Math.Ceiling(fMiddleDecimal) : 0));
                    if (arrsortedAray[iMiddleIndex] == numberToBeSarched)
                    {
                        sSearchResult = NumberFoundString();
                        break;
                    }
                    else if (numberToBeSarched < arrsortedAray[iMiddleIndex])
                    {
                        iRightIndex = iMiddleIndex;

                    }
                    else if (numberToBeSarched > arrsortedAray[iMiddleIndex])
                    {
                        iLeftIndex = iMiddleIndex;
                    }
                }
            }
            else if (arrsortedAray.Length == 1)
            {
                if (arrsortedAray[0] == numberToBeSarched)
                {
                    sSearchResult = NumberFoundString();
                }
                else
                {
                    sSearchResult = NumberNotFoundString();
                }
            }
            else
            {
                sSearchResult = "Invalid Array Input";
            }
            return sSearchResult;
        }

        private static string NumberNotFoundString()
        {
            return "Number not Found";
        }

        private static string NumberFoundString()
        {
            return "Number found";
        }
    }
}
