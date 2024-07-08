using System.Globalization;

namespace Assignment10._2._1LINQCondition
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] myNum = { 2, -1, 3, -3, 10, -200  };

            var numQuery = from num in myNum
                           where num >=0
                           select num;

            foreach (int num in numQuery)
            {
                Console.Write(num + " ");
            }
        }
    }
}
