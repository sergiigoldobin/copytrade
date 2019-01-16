using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class City
    {
        public string Name;
        public int Latitude;
        public int Longtitude;

    }
    class Citizen
    {
        public string Name;
        public string Surname;
        public int identificationNumber;
        private bool isSpy;
        public void CheckIfSpy()
        { 
            if (Name == "Serhii")
            {
                isSpy = true;
            }
        }
        public string Sentence()
        {
            if (isSpy)
            {
                return "Shoot him";
            }
            else
            {
                return "Let him live";
            }
        }
    }
    class Program
    {

        static void Lesson1()
        {
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
        static void Lesson2()
        {
            int[] hundred = new int[100];
            for (int j = 1; j <= 100; j++)
            {
                bool isprimenumber = true;
                for (int k = 2; k <= j - 1; k++)
                {
                    if (j % k == 0)
                    {
                        isprimenumber = false;
                    }
                }
                if (isprimenumber)
                {
                    Console.WriteLine(j);
                }

            }

        }
        static void Lesson3()
        {
            //string write = "What you want from me, jerk?" ;
            //Console.WriteLine(write);
            string read = Console.ReadLine();
            int read2;
            bool isparsed666 = int.TryParse(read, out read2);
            if (isparsed666 == false)
            {
                Console.WriteLine("Invalid Value!!!");
            }
            else
            {
                Console.WriteLine("Valid Value");
                if (read2 % 2 == 0)
                {
                    Console.WriteLine("It's even");
                }
                else
                {
                    Console.WriteLine("It's odd");
                }

            }

        }
        static void Lesson4()
        {
            int[] ages = new int[] { 1, 9, 13, 16, 21, 46, 99 };
            Console.WriteLine(ages[5]);
            ages[5] = 100;
            Console.WriteLine(ages[5]);
            Console.WriteLine(ages.Length);
            Console.ReadLine();
        }
        static void Lesson5()
        {
            string[] string888 = new string[5];

            for (int i = 0; i < 5; i++)

            {
                string888[i] = Console.ReadLine();
            }
            int i2 = 0;
            while (i2 < 5)
            {
                Console.WriteLine(string888[i2]);
                i2++;
            }
        }
        static void Lesson6()
        {
            var integers = new int[] { 12, 3, -9, 81, 14, 0 };
            for (int i = 0; i < integers.Length; i++)
            {
                Console.WriteLine($"N{i}={integers[i]}");
            }
            for (int k = 0; k < integers.Length; k++)
            {
                int minElementOfArray = int.MaxValue;
                int numberOfMinElement = int.MinValue;


                for (int g = k; g < integers.Length; g++)
                {
                    if (minElementOfArray > integers[g])
                    {
                        minElementOfArray = integers[g];
                        numberOfMinElement = g;
                    }

                }
                Console.WriteLine($"minElementOfArray N{numberOfMinElement} = {minElementOfArray}");
                integers[numberOfMinElement] = integers[k];
                integers[k] = minElementOfArray;

            }
            for (int i = 0; i < integers.Length; i++)
            {
                Console.WriteLine($"N{i}={integers[i]}");
            }
        }
        static void Lesson7()
        {
            string[] string888 = new string [5];
            

            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine(string888[i]);
            }
        }     
        static void Lesson8()
        {
            string[] string888 = new string[5];

            string888[0] = Console.ReadLine();
            string888[1] = Console.ReadLine();
            string888[2] = Console.ReadLine();
            string888[3] = Console.ReadLine();
            string888[4] = Console.ReadLine();
            Console.WriteLine(string888[0]);
            Console.WriteLine(string888[1]);
            Console.WriteLine(string888[2]);
            Console.WriteLine(string888[3]);
            Console.WriteLine(string888[4]);
        }
        static void Lesson9()
        {
            Method();
            Field = Field + 1;
            Console.WriteLine(Field);


            string multiple1 = Console.ReadLine();
            int multiple2;
            bool multiple3 = int.TryParse(multiple1, out multiple2);

            if (multiple3 == true)
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
        }
        static void Lesson10()
        {
            Console.WriteLine("I can't create methods");
          
  
        }
        static void Lesson11()
        {
            string consoleInput;
            do
            {
                Console.WriteLine("Type_Something");
                consoleInput = Console.ReadLine();

                if (consoleInput == "yes")

                {
                    Console.WriteLine("no");

                }
                else
                {
                    if (consoleInput == "no")
                    {
                        Console.WriteLine("yes");
                    }
                    else
                    {
                        Console.WriteLine("I don't understand you");
                    }
                }

            }
            while (!(consoleInput == "Sunstone"));

        }

        static void Lesson13()
        {
            //define class City with next fields:
            //name
            //latitude
            //longitude
            //Define method on this class which will calculate distance to this city from north pole
            //coordinates of north pole is 0, 0
            //formula for distance = square root of ( x ^2 + y^2)
            //Create array of 3 cities of choise
            //print to conole distance from north pole for each city
        }
        

        static int Field;
        static void Method()
        {
            Console.WriteLine(Field);
            Field = 1;
            Console.WriteLine(Field);
        }
        static void Main(string[] args)
        {
            var cities = new City[3];
            for (var i = 0; i < cities.Length; i++)
            {
                Console.WriteLine("Input name");
                var name = Console.ReadLine();
                Console.WriteLine("Input latitude");
                var latitude = Console.ReadLine();
                Console.WriteLine("Input longtitude");
                var longitude = Console.ReadLine();
                //int identificationNumber = int.Parse(Console.ReadLine());
                //if (!int.TryParse(Console.ReadLine(), out int identificationNumber))



                return;
                {
                    Console.WriteLine("Invalid number, try again");
                    continue;
                }
                var cities1 = new City();
                cities1.Name = name;
                int cities1.Latitude = latitude;
                cities1.Longtitude = longtitude;
                cities1[i] = cities;

                cities[i] = new City();
                //citizens[i].Name = name;
                //citizens[i].Surname = surname;
                //citizens[i].identificationNumber = identificationNumber;

                cities[i] = new City
                {
                    Name = name,
                    Latitude = latitude,
                    Longtitude = longtitude
                };

                return
            }
            
            for (var i = 0; i < citizens.Length; i++)
            {
                citizens[i].CheckIfSpy();
                Console.WriteLine($"{citizens[i].Name} {citizens[i].Surname} - {citizens[i].Sentence()}");
            }

        }
    }
}