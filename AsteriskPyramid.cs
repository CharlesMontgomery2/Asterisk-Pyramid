using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Asterisk_Pyramid
{
	class Program
	{

		static void AsteriskPyramid(int x) // A method that has a single perameter
		{
			for(int y=1; y<=x; y++) // y is collomns of the asteriks where y will be <= the number of stars in highth will loop if true.
			{
				for(int z=y; z<=x; z++) //
				{
					Console.Write("  "); // Make sure there is doouble spacing in the perenthesis or the pyramid will not be even.
				}
				for(int k=1; k<=2*y-1; k++) // k are the rows  of asteriks which shows 2 multiplied by the number of previous row of astericks.
				{
					Console.Write("*" + " ");
				}
				Console.WriteLine();
			}
		}
		static void Main(string[] args)
		{
			AsteriskPyramid(10); // The number will be equal to the amount of asterisks in highth.
		}
	}
}
