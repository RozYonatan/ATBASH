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
            string message = "Lfi ulixvh ziv kivkzirmt uli z nzqli zggzxp lm gsv Arlmrhg vmvnb. Gsv ilxpvg fmrgh ziv ivzwb zmw dzrgrmt uli gsv hrtmzo. Ylnyh szev yvvm kozxvw mvzi pvb olxzgrlmh. Mfpsyz urtsgvih ziv hgzmwrmt yb uli tilfmw rmurogizgrlm. Gsv zggzxp droo yv hfwwvm zmw hgilmt -- gsvb dlm’g hvv rg xlnrmt.Dv nfhg hgzb srwwvm zmw pvvk gsv kozm hvxivg fmgro gsv ozhg nlnvmg. Erxglib rh mvzi. Hgzb ivzwb.";
            string[] words = { "bomb", "nukhba", "fighter", "rocket", "secret" };
            string descripMessage = description(message);
            int danger = dangerCheck(words, descripMessage);
            warning(descripMessage, danger);
        }
        static int convert(int asciivalu)
        {
            int asci2num = 219;
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
                Console.WriteLine($"ULTRA ALERT!: {sentence}\nget {danger} points");
            }
            else
            {
                Console.WriteLine("The sentence is safe.");
            }
        }
    }
}
