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
            // evry 30 days = 10 hovercraft
            // 1 hovercraft = $2,000,000
            // 1 hovercraft sells = $3,000,000
            // each month = $1,000,000
            // output that states
            // profit
            // loss
            // broke even
            // first lets see how many hovercrafts have to sell for minimum profit
            // 21,000,000 it costs a month to make 10 hovercrafts and insurance
            // 21,000,000/3,000,000 =7 so more than 7 hovercrafts have to be sold
            // profit > 7 hovercrafts sold
            // Loss < 7 hovercrafts to be sold
            // broke even == 7 hovercrafts sold

            Console.WriteLine("Enter the amount of hovercrafts sales for this month: ");
            int sales = int.Parse(Console.ReadLine());

            if (sales > 7)
                Console.WriteLine("You made a Profit!");
            else if (sales == 7)
                Console.WriteLine("You Broke Even.");
            else
                Console.WriteLine("You had a Loss.");

        }
    }
}
