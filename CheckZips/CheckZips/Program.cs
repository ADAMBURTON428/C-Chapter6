using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;
namespace CheckZips
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] zipCode = { 11111, 12685, 77777, 12345, 77677, 22222, 10023, 54321, 20012, 97654};
            int userZipe = 0;

            WriteLine("Enter a 5 digit Zip Code ");
            userZipe = Convert.ToInt32(ReadLine());

            for (int i = 0; i < zipCode.Length; i++)
            {
                if(zipCode[i] == userZipe)
                {
                    WriteLine("We can deliver");
                }
                else
                    WriteLine("We can't");

            }
            







        }
    }
}
