using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Asterisk_Pyramid
{
    class Program
    {

        static void AsteriskPyramid(int x)
        {
            for(int y=1; y<=x; y++)
            {
                for(int z=y; z<=x; z++)
                {
                    Console.Write("   ");
                }
                for(int k=1; k<=2*y-1; k++)
                {
                    Console.Write("*" + " ");
                }
                Console.WriteLine();
            }
        }
        static void Main(string[] args)
        {
            AsteriskPyramid(10);
        }
    }
}
