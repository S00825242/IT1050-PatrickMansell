using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("initial value, control variable, increment, and the loop continuation condiution are the four basice elements of the counter-controlled repetition.");
            Console.WriteLine("'while' loop can be written anbywhere in the loop. The 'for' loop is written from top to bottom so only goes after all statements are executed.");
            Console.WriteLine("Almost opposite to 'for' statements are the do-while where they are expressed from bottom to top. This makes statements to execute at least once, within the doblock");

            int i;
            for (i = 1; i < 101; i++)
            {
                Console.WriteLine(i); if ((i % 2) == 0) { Console.WriteLine("This number is Even"); }
                else { Console.WriteLine("This number is Odd"); }
            }
            Console.ReadLine();
        }
    }
}


{Console.WriteLine("Please Enter a Temperature");
            int Temp = Convert.ToInt32(Console.ReadLine());
            if (Temp >= 90) { Console.WriteLine("fish"); }
            else if (Temp >= 80) { Console.WriteLine("Lion"); }
            else if (Temp >= 70) { Console.WriteLine("Turtle"); }
            else if (Temp >= 60) { Console.WriteLine("Deer"); }
            else if (Temp >= 50) { Console.WriteLine("Reindeer"); }
            else if (Temp >= 40) { Console.WriteLine("Moose"); }
            else if (Temp >= 20) { Console.WriteLine("Penguin"); }
            else if (Temp >= 10) { Console.WriteLine("Polar Bear"); }
            else { Console.WriteLine("Bug"); }}
    }



    Console.WriteLine("Please Enter an Exhibit number");
            String str = Console.ReadLine();
int caseSwitch = int.Parse(str);
            switch(caseSwitch)
            {
                case 1:
                    Console.WriteLine("Polar Bear");
                    break;
                case 2:
                    Console.WriteLine("Penguin");
                    break;
                case 3:
                    Console.WriteLine("Moose");
                    break;
                case 4:
                    Console.WriteLine("Reindeer");
                    break;
                case 5:
                    Console.WriteLine("Deer");
                    break;
                case 6:
                    Console.WriteLine("Turtle");
                    break;
                case 7:
                    Console.WriteLine("Lion");
                    break;
                case 8:
                    Console.WriteLine("Fish");
                    break;
                case 9:
                    Console.WriteLine("Bug");
                    break;
            }
          
        }
    }int i = 9;
            while(i< 21)
            {
                i++;
                Console.WriteLine(i);
            }

        }


    do(int i = 0; i< 101; i++)
Console.WriteLine(i);
while(int >1)
    Console.WriteLine("********");




