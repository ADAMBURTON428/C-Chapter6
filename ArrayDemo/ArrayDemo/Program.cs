using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;
namespace ArrayDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = new int[8];
            int i;
          
            for (i = 0; i < 8; i++)
            {
                Write("Enter a Number - " + i + " <<");
                arr[i] = Convert.ToInt32(ReadLine());
            }

            int option;

            WriteLine("Choose option 1 for viewing the list in order first to last postion." +
                "Choose option 2 for view the order last to first. Choose option 3 to select a position.\n");
            option = Convert.ToInt32(ReadLine());

            if (option == 1)
            {
                for (int j = 0; j < arr.Length; j++)
                {
                    WriteLine(arr[j]);
                }
            }
            else if (option == 2)
            {
                for (int b = 7; b >= 0; b-- )
                {
                    
                    WriteLine(arr[b]);
                }
            }
            else if (option == 3)
            {
                int choice;
                
                WriteLine("What position ");
                choice = Convert.ToInt32(ReadLine());
                WriteLine("The number is " + arr[choice]);

            }
            ReadLine();
        }
    }
}
