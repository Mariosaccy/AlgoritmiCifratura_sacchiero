using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgoritmoDiCesare_sacchiero
{
    public static class CifVigenere
    {

        // Cifra il testo utilizzando il cifrario di Vigenère con la chiave specificata
        public static string Cifra(string testo, string chiave)
        {
            string testoCifrato = "";
            int chiaveIndex = 0;
            foreach (char c in testo)
            {
                if (char.IsLetter(c))
                {
                    char baseChar = char.IsUpper(c) ? 'A' : 'a';
                    char cCifrato = (char)((((c - baseChar) + (char.ToUpper(chiave[chiaveIndex]) - 'A')) % 26) + baseChar);
                    testoCifrato.Append(cCifrato);
                    chiaveIndex = (chiaveIndex + 1) % chiave.Length;
                }
                else
                {
                    testoCifrato.Append(c);
                }
            }
            return testoCifrato;
        }

        // Decifra il testo cifrato utilizzando il cifrario di Vigenère con la chiave specificata
        public static string Decifra(string testo, string chiave)
        {
            StringBuilder testoDecifrato = new StringBuilder();
            int chiaveIndex = 0;
            foreach (char c in testo)
            {
                if (char.IsLetter(c))
                {
                    char baseChar = char.IsUpper(c) ? 'A' : 'a';
                    char cDecifrato = (char)((((c - baseChar) - (char.ToUpper(chiave[chiaveIndex]) - 'A') + 26) % 26) + baseChar);
                    testoDecifrato.Append(cDecifrato);
                    chiaveIndex = (chiaveIndex + 1) % chiave.Length;
                }
                else
                {
                    testoDecifrato.Append(c);
                }
            }
            return testoDecifrato.ToString();
        }
    }
}
