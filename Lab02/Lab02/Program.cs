using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab02
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("{0}\n{1}", "Hello World!", "From Pat Mansell");

            Console.WriteLine("Hello World!     From Pat Mansell");

            Console.WriteLine("a. Main()");

            Console.WriteLine("b. an integer describes whole numbers while a floating number denotes big numbers/complex numbers. 32 bit storage vs 64 bits ");

            Console.WriteLine("c. A method would be public voice with a displaymessage(), so the hello world would be classified as a method");

            Console.WriteLine("d. set assigns the method's value and get accessor reads the value ");

            Console.WriteLine("e. Objects are the backbone that holds everything in place, then classes exist inside objects which can house a variety of methods. You can only have 1 static class as anything else would break.  ");
            int number1; // declare first number to multiply
            int number2; // delcare second number to multiply
            int sum; // declare sum of number1 and number2

            Console.Write("Enter first integer:"); // prompt user // read first number from user
            number1 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter second integer:"); // prompt user // read second number from user
            number2 = Convert.ToInt32(Console.ReadLine());

            sum = number1 * number2; // first number mutiplied by second number
            Console.WriteLine("Sum is={0}", sum); //display sum
        }
    }
        }