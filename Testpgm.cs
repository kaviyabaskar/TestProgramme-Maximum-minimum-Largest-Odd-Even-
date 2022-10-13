using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace TestProgramme
{
    internal class Testpgm
    {
        //properties
        int drl;
        float USD = 82.38f;
        float result;
        int min, max, output;
        int m1, m2, m3, m4;
        int OddEven;
        public void OddEven1()
        {
            Console.WriteLine("Enter Minimum Value");
            min = Convert.ToInt32(Console.ReadLine());
            min = min + 1;
            Console.WriteLine(" Enter Maximum Value");
            max = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Even Number");
            for (int i = min; i < max; i++)
            {
                if (i % 2 == 0)
                {
                    Console.WriteLine(i);
                    i++;
                }
            }
            Console.WriteLine("Odd Number");
            for (int i = min; i < max; i++)
            {
                if (i % 2 == 1)
                {
                    Console.WriteLine(i);
                    i++;
                }
            }



            /*public void largest()
             {
                Console.WriteLine("Enter Number 1:");
                 m1 = Convert.ToInt32(Console.ReadLine());
                 Console.WriteLine("Enter Number 2:");
                 m2= Convert.ToInt32(Console.ReadLine());
                 Console.WriteLine("Enter Number 3:");
                 m3 = Convert.ToInt32(Console.ReadLine());
                 if (m1 > m2)
                 {
                     if (m1 > m3)
                     {
                         Console.Write($"{m1}is the larger number than {m2} and {m3}");
                     }
                     else
                     {
                         Console.Write($"{m3}is the larger number than {m2} and {m1}");
                     }
                 }
                 else if (m2 > m3)
                     Console.Write($"{m2}is the larger number than {m1} and {m3}");
                 else
                     Console.Write($"{m3}is the larger number than {m2} and {m1}");
             }
         }
     }*/
            /* public static void dollor()
               {
                   Console.WriteLine("How many dollors do you want to convert into India Rupees");
                   drl = Convert.ToInt32(Console.ReadLine());
                   result = drl * USD;
                   Console.WriteLine($"Today's Rate 1 USD value is:{USD}");
                   Console.WriteLine($"Anwer:{result}INR");
               }
               public void sum()
               {
                   Console.WriteLine("Enter Number 1:");
                 //m1 = Convert.ToInt32(Console.ReadLine());
                   Console.WriteLine("Enter Number 2:");
                   //m2= Convert.ToInt32(Console.ReadLine());
                   Console.WriteLine("Enter Number 3:");
                  // m3 = Convert.ToInt32(Console.ReadLine());
                   Console.WriteLine("Emnter Number 4:");
                   //m4= Convert.ToInt32(Console.ReadLine());
                   //result = m1 + m2 + m3 + m4;
                   Console.WriteLine($"The Total Number of 4 Numbers is {result}");
               }
               public void mnn()
               {
                   Console.WriteLine("Enter A Number:");
                   min =Convert.ToInt32(Console.ReadLine());
                   for (int i= 0; i < min; i++)
                   {
                       Console.WriteLine($"{i}");
                   }
               }
               //methods

               public void DisplayBetweenNumbers()
               {
                   Console.WriteLine(  "Enter Minimum Value");
                   min = Convert.ToInt32(Console.ReadLine());
                   min = min+1;
                   Console.WriteLine(" Enter Maximum Value");
                   max = Convert.ToInt32(Console.ReadLine());
                   for (int i = min; i < max; i++)
                   {


                       Console.WriteLine(i);
                   }
               }*/
        }
    }
}
    