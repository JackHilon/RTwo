using System;

namespace RTwo
{
    class Program
    {
        static void Main(string[] args)
        {
            // R2 (RTwo)
            // https://open.kattis.com/problems/r2 
            // calculate second part (r2) in the mean (average) calculation (r1+r2)/2 = s 

            var parameters = Enter2Nums();
            var r1 = parameters[0];
            var s = parameters[1];


            Console.WriteLine(SecondPart(r1, s));
        }

        private static int SecondPart(int firstPart, int mean)
        {
            return (2 * mean) - firstPart;
        }
        private static int[] Enter2Nums()
        {
            string[] arr = new string[2] { "", "" };
            int[] res = new int[2] { 0,0 };
            try
            {
                arr = Console.ReadLine().Split(' ', 2);
                for (int i = 0; i < arr.Length; i++)
                {
                    res[i] = int.Parse(arr[i]);
                    if (res[i] < -1000 || res[i] > 1000)
                        throw new ArgumentException();
                }
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
                return Enter2Nums();
            }
            return res;
        }
    }
}
