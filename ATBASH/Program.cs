using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATBASH
{
    internal class Program
    {
        static int convert(int asciivalu)
        {
            int asci2num = 218;
            return asci2num - asciivalu;
        }
        static string description(string message)
        {
            char ch;
            int asciiValu;
            string descripMessage = "";
            foreach (char c in message)
            { 
                if (char.IsLetter(c))
                {
                    ch = char.ToLower(c);
                    asciiValu = (int)ch;
                    ch = (char)convert(asciiValu);
                    descripMessage += ch;
                }
                else
                {
                    descripMessage += c;
                }
            }
            return descripMessage;
        }
        static void Main(string[] args)
        {
        }
    }
}
