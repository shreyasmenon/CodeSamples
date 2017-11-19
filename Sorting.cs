using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortingAlgo
{
    class Program
    {
        static void Main(string[] args)
        {
            //Program for Sorting
            //Read an Array from user
            Console.WriteLine("Please enter aarray elements in a single line");
            string sArrayElements = Console.ReadLine();
            string[] arrUnsortedStringArray = sArrayElements.Split(' ');
            double[] arrUnsortedDoubleArray = new double[arrUnsortedStringArray.Length];
            double[] arrSortedArray = new double[arrUnsortedStringArray.Length];
            for (int i = 0; i < arrUnsortedStringArray.Length; i++)
            {
                arrUnsortedDoubleArray[i] = Double.Parse(arrUnsortedStringArray[i]);
            }
            //Selection Sort
            // arrSortedArray = SelectionSort(arrUnsortedDoubleArray);

            //Bubble Sort
            //arrSortedArray = BubbleSort(arrUnsortedDoubleArray);

            //Insertion sort
            arrSortedArray = InsertionSort(arrUnsortedDoubleArray);
            for (int i = 0; i < arrSortedArray.Length; i++)
            {
                Console.WriteLine("{0}", arrSortedArray[i]);
            }
            Console.ReadLine();
        }



        private static double[] BubbleSort(double[] arrUnsortedDoubleArray)
        {
            int n = arrUnsortedDoubleArray.Length;
            for (int i = 0; i < n; i++)
            {
                //double dLargestElemnent = arrUnsortedDoubleArray[i];
                for (int j = 0; j < n - 1; j++)
                {
                    double temp = 0;
                    if (arrUnsortedDoubleArray[j] > arrUnsortedDoubleArray[j + 1])
                    {
                        //swap
                        temp = arrUnsortedDoubleArray[j + 1];
                        arrUnsortedDoubleArray[j + 1] = arrUnsortedDoubleArray[j];
                        arrUnsortedDoubleArray[j] = temp;
                    }
                }
            }
            return arrUnsortedDoubleArray;
        }

        private static double[] SelectionSort(double[] arrUnsortedDoubleArray)
        {
            int n = arrUnsortedDoubleArray.Length;
            for (int i = 0; i < n; i++)
            {
                int index = 0;
                bool bSmallestFound = false;
                double smallest = arrUnsortedDoubleArray[i];
                for (int j = i; j < n; j++)
                {
                    if (arrUnsortedDoubleArray[j] < smallest)
                    {
                        smallest = arrUnsortedDoubleArray[j];
                        index = j;
                        bSmallestFound = true;
                    }
                }
                if (bSmallestFound)
                {
                    double temp = arrUnsortedDoubleArray[i];
                    arrUnsortedDoubleArray[i] = smallest;
                    arrUnsortedDoubleArray[index] = temp;
                }
            }
            return arrUnsortedDoubleArray;
        }



        private static double[] InsertionSort(double[] arrUnsortedDoubleArray)
        {
            for (int i = 0; i < arrUnsortedDoubleArray.Length - 1; i++)
            {
                int j = i + 1;
                while (j > 0)
                {
                    if (arrUnsortedDoubleArray[j - 1] > arrUnsortedDoubleArray[j])
                    {
                        //swap
                        double dTemp = arrUnsortedDoubleArray[j];
                        arrUnsortedDoubleArray[j] = arrUnsortedDoubleArray[j - 1];
                        arrUnsortedDoubleArray[j - 1] = dTemp;
                    }
                    j--;
                }
            }
            return arrUnsortedDoubleArray;
        }

    }
}
