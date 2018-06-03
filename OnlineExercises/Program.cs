using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using Console = System.Console;

namespace OnlineExercises
{
    
    class Program
    {
        static void Main(string[] args)
        {
            //Write a C# Sharp program to print the output of multiplication of three numbers which will be entered by the user.
            //Go to the editor
            //            Test Data:
            //            Input the first number to multiply: 2
            //            Input the second number to multiply: 3
            //            Input the third number to multiply: 6
            //            Expected Output:
            //            2 x 3 x 6 = 36
            var numbers = new int[3];
            var order = new string[3] {"first", "second", "third"};
            for (var i = 0; i <= 2; i++)
            {
                Console.WriteLine("please enter the " + order[i] + " number");
                numbers[i] = Convert.ToInt32(Console.ReadLine());
                if (i == 2)
                {
                    var total = numbers[0] * numbers[1] * numbers[2];
                    Console.WriteLine(numbers[0] + " x " + numbers[1] + " x " + numbers[2] + " = " + total);
                    Console.WriteLine("");
                }
                    
            }
        }
    }
}
