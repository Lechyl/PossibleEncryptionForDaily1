using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace PossibleEncryptionForDaily1
{
    class Program
    {
        static void Main(string[] args)
        {
            Start:
            WriteLine("Kan decode Rovarsraket, skriv koden nu");
            string Text = ReadLine();

            //  string[] Encoder = { "bob", "coc", "dod", "fof", "gog", "hoh", "joj", "kok", "lol", "mom", "non", "pop", "qoq", "ror", "sos", "tot", "vov", "wow", "xox", "zoz" };
            char[] Konsonant = { 'b', 'c', 'd', 'f', 'g', 'h', 'j', 'k', 'l', 'm', 'n', 'p', 'q', 'r', 's', 't', 'v', 'w', 'x', 'z' };


            string output = "";
            for (int i = 0; i < Text.Length; i++)
            {
                Text.ToCharArray();
                if (Text[i] == 'o' && i > 0)
                {
                    if (Text[i + 1] == Text[i - 1])

                        output += Text[i -1].ToString();

                }
                else if ((Array.Exists(Konsonant, x => x == Text[i]))!= true )
                {
                    output += Text[i].ToString();

                }

            }
            WriteLine("Din kode : "+Text);
            WriteLine("Decoded version : " +output);
            WriteLine("////////////////////////////////////////////////////////////////////////////////////////");
            goto Start;
            ReadLine();
        }
    }
}
