using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATBASH
{
    internal class Program
    {
        static void Main(string[] args)
        {
        // hi i'm yonatan
        }
        static int dangerCheck(string[] words, string sentence)
        {
            int danger = 0;
            foreach (string word in words)
            {
                if (sentence.Contains(word))
                {
                    danger++;
                }
            }
            return danger;
        }
    }
}
