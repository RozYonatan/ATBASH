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
        static void warning(string sentence, int danger)
        {
            if (danger >= 1 && danger <= 5)
            {
                Console.WriteLine($"WARNING!: {sentence} get {danger} points");
            }
            else if (danger >= 6 && danger <= 10)
            {
                Console.WriteLine($"DANGER!: {sentence} get {danger} points");
            }
            else if (danger >= 11 && danger <= 15)
            {
                Console.WriteLine($"ULTRA ALERT!: {sentence} get {danger} points");
            }
            else
            {
                Console.WriteLine("The sentence is safe.");
            }
        }
    }
}
