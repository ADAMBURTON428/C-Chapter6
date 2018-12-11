using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;
namespace TemperatureList
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] temp = new int[7];
            int i;
            int tempAverage;
            int Total = 0;

            for (i = 0; i < temp.Length; i++)
            {
                WriteLine("Enter High Tempatures for seven days");
                temp[i] = Convert.ToInt32(ReadLine());
                Total = temp[i] + Total;
            }
            
            tempAverage = Total / temp.Length;
            WriteLine("The temperature average =" + tempAverage);
            for (int j = 0; j < temp.Length; j++)
            {
                WriteLine("The difference for temp " + temp[j] + " and the average is " + (temp[j] - tempAverage));
            }

        }
    }
}
