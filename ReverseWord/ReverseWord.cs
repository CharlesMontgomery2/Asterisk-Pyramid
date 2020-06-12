using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Configuration;
using System.Text;
using System.Threading.Tasks;

namespace AlienTalk
{
    class Program
    {
       static string AlienTranslation(string msg)
        {
           
            char[] arr = msg.ToCharArray();
            Array.Reverse(arr);
            return new string(arr);

        }
        static void Main(string[] args)
        {
            Console.Write("Input word: ");
            string arr = Console.ReadLine();
            Console.WriteLine(AlienTranslation(arr));
            

        }
       
    }
}

