using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReverseWord
{
    class Program
    {
        static string reverseText(string msg) //A string method to reverse user's text.
        {

            char[] arr = msg.ToCharArray();// Char array used to make the text into a character array giving the variable name arr.
            Array.Reverse(arr);         // The variable (arr) is the array to be reversed.
            return new string(arr);     // This returns the new string arr that has been reverse.

        }
        static void Main(string[] args)
        {
            Console.Write("Input word: ");  //Promts the user to input a word.
            string arr = Console.ReadLine();  // Reads the users input as a string and the value is named the same as in line 14.
            Console.WriteLine(reverseText(arr));  // Displays the called method of the users input in reverse.
        }
    }
}
