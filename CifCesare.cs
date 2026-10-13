using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgoritmoDiCesare_sacchiero
{
    public static class CifCesare
    {

        // Cifra il testo utilizzando il cifrario di Cesare con la chiave specificata
        public static string Cifra(string testo, int chiave)
        {
            string testoCifrato = "";
            foreach (char c in testo)
            {
                if (char.IsLetter(c))
                {
                    char baseChar = char.IsUpper(c) ? 'A' : 'a';
                    char cCifrato = (char)((((c - baseChar) + chiave) % 26) + baseChar);
                    testoCifrato+=cCifrato;
                }
                else
                {
                    testoCifrato += c;
                }
            }
            return testoCifrato;
        }

        // Decifra il testo cifrato utilizzando il cifrario di Cesare con la chiave specificata
        public static string Decifra(string testo, int chiave)
        {
            return Cifra(testo, 26 - (chiave % 26));
        }
    }
}
