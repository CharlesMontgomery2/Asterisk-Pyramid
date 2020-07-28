using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Popsicles
{
    class Program
    {
        static void Main(string[] args)
        {
            // determine the amount of popsicles  to give away or eat them yourself
            // if the number of popsicles can be distributed evenly to the given amount of people then "Give Away"
            // if the number of popsicles can not be distributed evenly then "Eat them youself"

            Console.WriteLine("Enter the amount of people who want popsicles: ");
            int people = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter the amount of popsicles: ");
            int popsicles = Convert.ToInt32(Console.ReadLine());

            if (popsicles % people == 0)
                Console.WriteLine("Give Away");
            else
                Console.WriteLine("Eat the popsicles yourself.");
        }
    }
}
