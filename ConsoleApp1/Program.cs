using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] ages = new int[] { 1, 9, 13, 16, 21, 46, 99 };
            Console.WriteLine(ages[5]);
            ages[5] = 100;
            Console.WriteLine(ages[5]);
            Console.WriteLine(ages.Length);
            Console.ReadLine();
            return;

            string multiple1 = Console.ReadLine();
            int multiple2;
            bool multiple3 = int.TryParse(multiple1, out multiple2);
        
            if (multiple3==true)
            {
                if (multiple2 % 5 == 0 && multiple2 % 2 == 0)
                {
                    Console.WriteLine("It's multiple of 5 and 2");
                }

                else
                {

                    if (multiple2 % 5 == 0)
                    {
                        Console.WriteLine("It's multiple of 5");
                    }

                    if (multiple2 % 2 == 0)
                    {
                        Console.WriteLine("It's multiple 2");
                    }
                }
                
            }


            return;
            //string write = "What you want from me, jerk?" ;
            //Console.WriteLine(write);
            string read = Console.ReadLine();
             //fgfg
      
            int read2;
            bool isparsed666 = int.TryParse(read, out read2);
            if (isparsed666 == false)
            {
                Console.WriteLine("Invalid Value!!!");
            }
            else
            {
                Console.WriteLine("Valid Value");
            if (read2 % 2 ==0)
            {
                Console.WriteLine("It's even");
            }
                else
                {
                    Console.WriteLine("It's odd");
                }

            }       

            

          
            return;
            string mytextvariable;
            string anothertextvariable = "c";
            mytextvariable = "edf";
            mytextvariable = "a" + "b" + anothertextvariable + mytextvariable;
            Console.WriteLine(mytextvariable);
            int s1;
            s1 = 1;
            int s2;
            s2 = 2;
            int sum; sum = 1 + 2;
            Console.WriteLine(sum);
            int rex = 1;
            var barsik = rex + 0.5;
            Console.WriteLine();
            if (mytextvariable == "d")
            {
                anothertextvariable = "c";
            }
            else
            {
                anothertextvariable = "y";
            }
            if (barsik == 1.5)
            {
                Console.WriteLine("hit");
            }
            else
            {
                Console.WriteLine("not hit");
            }
            {
                Console.WriteLine("Enter input:"); // Prompt
                string line = Console.ReadLine(); // Get string from user
                if (line == "exit") // Check string
                
                {
                
                }
                Convert.ToInt32(line);
                int crying = Convert.ToInt32(line) + 1;
                Console.WriteLine(crying);

                Console.Write("You typed "); // Report output
                Console.Write(line);
                Console.WriteLine(" character(s)");
            }
            int superman;
            bool isparsed = int.TryParse("10", out superman);
            {
                int x;
                x = 3;
                int y;
                y = 5;
                var z = x + y;

                if (z == 9)
                {
                    Console.WriteLine("it is equal to 9");
                }
                else
                {
                    Console.WriteLine(z);

                }

                






















            }
        }
    }
}