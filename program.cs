using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Szyfry
{
    class Cypher
    {
        
        public static string Gaderypoluki(string text)
        {
            Dictionary<char, char> pairs = new Dictionary<char, char>()
            {
                {'G', 'A'}, {'A', 'G'},
                {'D', 'E'}, {'E', 'D'},
                {'R', 'Y'}, {'Y', 'R'},
                {'P', 'O'}, {'O', 'P'},
                {'L', 'U'}, {'U', 'L'},
                {'K', 'I'}, {'I', 'K'}
            };

            text = text.ToUpper().Replace(" ", "");
            string output = "";

            foreach (char c in text)
            {
                if (pairs.ContainsKey(c))
                    output += pairs[c]; 
                else
                    output += c;        
            }

            return output;
        }

        public static string CaesarShift(string text)
        {
            text = text.ToUpper().Replace(" ", "");
            string output = "";

            foreach (char c in text)
            {
                if (c >= 'A' && c <= 'Z')
                {
                    char shifted = (char)(c + 3);
                    if (shifted > 'Z')
                        shifted = (char)(shifted - 26);
                    output += shifted;
                }
                else
                {
                    output += c;
                }
            }

            return output;
        }
    }
}
