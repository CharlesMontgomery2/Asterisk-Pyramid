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
            for (int row = 0; row <= 6; row++)
            {
                for (int column = 0; column <= 50; column++)
                {
                    if ((column == 1 && (row != 0 && row != 6)) ||
                        ((row == 0 || row == 6) && (column > 1 && column < 5)) ||
                        (column == 5 && (row == 1 || row == 5)) ||
                        ((column == 8 || column == 12) ||
                        (row == 3 && column > 8 && column < 13)) ||
                        ((column == 15 || column == 19) && row != 0) ||
                        ((row == 0 || row == 3) && (column > 15 && column < 19)) ||
                        ((column == 22 || ((row == 0 || row == 3) &&
                        column > 22 && column < 26) ||
                        (column == 26 && row != 0 && row < 3) ||
                        column == row + 20 && row > 2)) ||
                        (column == 29 || (row == 6 && column > 28 && column < 34)) ||
                        (column == 36 || ((row == 0 || row == 6) &&
                        column > 36 && column < 41)) ||
                        (row == 3 && column > 36 && column < 41) ||
                        (((row == 0 || row == 3 || row == 6) &&
                        column > 43 && column < 47) ||
                        (column == 43 && (row == 1 || row == 2 || row == 6)) ||
                        (column == 47 && (row == 0 || row == 4 || row == 5))))

                        Console.Write("+");
                    else
                        Console.Write("0");
                }
                Console.Write("\n");
            }
            Console.WriteLine("\n\n");

        }
    }
}
