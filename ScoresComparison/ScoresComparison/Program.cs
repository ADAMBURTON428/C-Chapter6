using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;
namespace ScoresComparison
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] score = new int[4];
            int i;
            int lowScore = 0;
            for (i = 0; i < score.Length; i++)
            {
                WriteLine("Enter Score ");
                score[i] = Convert.ToInt32(ReadLine());
                
               
            }
            for (int j = 0; j < score.Length; j++)
            {
                if (score[j] > lowScore)
                {
                    lowScore = score[j];
                    WriteLine("Congrats");
                }
                else if (score[j] < lowScore)
                {
                    
                    WriteLine("You failed");
                }
            }
           
         
        }
    }
}
