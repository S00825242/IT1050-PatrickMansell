using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Midterm
{
    class Program
    {
        public static object Write { get; private set; }

        static void Main(string[] args)
        {
            Console.WriteLine("There are three types of control structures: Sequential, Selection, and Repetition");
            Console.WriteLine("Repitition is used for creating a loop- using while, do/while, and for commands");
            Console.WriteLine("Selection uses commands if, if/else, and switch and these are the most common alternative paths.");
            Console.WriteLine("Sequential is used to execute code statements.");

            int i = 10;
            Boolean keepLooping = true;
            while (keepLooping)
            {
                if (i>= 9) keepLooping = false;
                i++; Console.WriteLine(i);

                {
                    int i = 1; while (i <= 64)
                    {
                        if ((i % 2) == 0)
                        { Console.WriteLine("[{0}]", i); }
                        else if ((i % 2) != 0) { Console.WriteLine(""); }
                        i *= 2;
                    }
                }
                string a = ",";
                int b;
                for (b = 99; b >= 1; --b)
                {
                    Console.Write(b);
                    if (b >= 2) { Console.Write(a); }
                }

                int i = 1;
                while (i <= 21) ;
                {
                    {
                        if ((i % 2) == 0) { Console.Write(""); } else if ((i % 2) != 0) { Console.Write(i); }
                        i++;
                    }
                }


                Console.WriteLine("For question 6 the output would be an asterisk and for the next question it would be nothing since i isn't greater than n.");



                Boolean hurricane;
                Boolean apocolypse;
                {  // declare boolean values
                    bool hurricane = false;
                    bool apocolypse = false;
                    if(!hurricane) & & (!apocolypse))
                        { Console.WriteLine("Let's go outside!");
                        Console.ReadLine(); }

                    }
                }
            }
        }
    }
}
           



















                 
