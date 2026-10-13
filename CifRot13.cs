using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgoritmoDiCesare_sacchiero
{
    public static class CifRot13
    {

        // Cifra il testo utilizzando il cifrario di Rot13
        public static string Cifra(string testo)
        {
            string testoCifrato = "";
            foreach (char c in testo)
            {
                if (char.IsLetter(c))
                {
                    char baseChar = char.IsUpper(c) ? 'A' : 'a';
                    char cCifrato = (char)((((c - baseChar) + 13) % 26) + baseChar);
                    testoCifrato.Append(cCifrato);
                }
                else
                {
                    testoCifrato.Append(c);
                }
            }
            return testoCifrato;
        }

        // Decifra il testo cifrato utilizzando il cifrario di Rot13 (è lo stesso metodo della cifratura)
        public static string Decifra(string testo)
        {
            return Cifra(testo);
        }
    }
}
