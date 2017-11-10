using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackerRanlDictionaries
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                int iNumberOfEntries = int.Parse(Console.ReadLine());
                Dictionary<string, string> dPhoneEntries = new Dictionary<string, string>();
                for (int i = 0; i < iNumberOfEntries; i++)
                {
                    string[] arrFriendsNameAndPhone = Console.ReadLine().Split(' ');
                    dPhoneEntries.Add(arrFriendsNameAndPhone[0].Trim(), arrFriendsNameAndPhone[1]);
                }
                List<string> lFirndsNames = new List<string>();
                string sFriendName = String.Empty;
                //For reading console inputs for unknown number of outputs
                do
                {
                    sFriendName = Console.ReadLine();
                    if (!string.IsNullOrEmpty(sFriendName))
                        lFirndsNames.Add(sFriendName);
                } while (!string.IsNullOrEmpty(sFriendName));

                FetchFriendsNumberAndPrint(dPhoneEntries, lFirndsNames.ToArray());

            }
            catch (Exception ex)
            {
                if (ex is InvalidCastException)
                {
                    Console.WriteLine("Invalid Input");
                }
                else if (ex is ArgumentOutOfRangeException)
                {
                    Console.WriteLine("Please enter the phone book entries in the correct format");
                }
                else
                    Console.WriteLine(ex.ToString());

            }
            Console.ReadLine();
        }

        private static void FetchFriendsNumberAndPrint(Dictionary<string, string> dPhoneEntries, string[] v)
        {
            foreach (string sFriendName in v)
            {
                string sPhoneNumber = string.Empty;
                dPhoneEntries.TryGetValue(sFriendName, out sPhoneNumber);
                if (!string.IsNullOrEmpty(sPhoneNumber))
                {
                    //PrintFOund
                    Console.WriteLine(string.Format("{0}={1}", sFriendName, sPhoneNumber));
                }
                else
                    //Print not Found
                    Console.WriteLine("Not found");
            }
        }
    }
}
