using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(" Scope: double width, double height. (Anything within the paranthesis in a method header) ");
            Console.WriteLine(" Static: access information from anyone within the code");
            Console.WriteLine(" Nonstatic: must locate information some other way within the code. ");
            Console.WriteLine(" Return Type: In this example it would be the double, it is how the program returns information.");
            Console.WriteLine(" Method Name: get Area for this example, tells the code where to collect information.");
            Console.WriteLine(" Parameters: In this example it would be public, communicates any access restrictions.");
            Console.WriteLine(" Method Body: Return height* width, it is the code that must be executed.");

            Console.WriteLine(" Methods can be reused in several locations within an application/code. As for uder-defined methods those are created by the user and are hidden which can cause some issue if the user is not carful.");

            Console.WriteLine(" See above, but static is just that- static can ca not have access to non-static fields. A nonstatic is free to explore the code.");


        }
    }
    public string bark;
    public static void bark();
    {Console.WriteLine("{0} is barking...", Chris);}


public string doTrick;
public static void doTrick("Roll Over");
 { 
Console.WriteLine( "{0} is so smart! {0} is doing a(n) {1}" , Chris, "Roll Over");
 }
