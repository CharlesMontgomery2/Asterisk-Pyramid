using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Runtime.DesignerServices;
using System.Runtime.Remoting.Channels;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace exercises
{
    class Program
    {

        static void Main(string[] args)
        {
            // For more than 10 yards the football team gains = high five
            // If no yards are gain  = shh
            // if they gain 10 or less yards then = ra

            Console.WriteLine("Enter the number of yards the team has gained: ");
            int yard = Convert.ToInt32(Console.ReadLine());

            if (yard <= 0)
                Console.WriteLine("shh");
            else if (yard <= 10)
            {
                for (int i = 0; i < yard; i++)
                {
                    Console.Write("Ra!");
                }
            }
            else
                Console.WriteLine("High Five");

        }
    }
}
