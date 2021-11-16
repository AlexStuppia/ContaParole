using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace ContaParole
{
    class Program
    {
        static void Main(string[] args)
        {
            string stringaDaContare = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Maecenas ipsum est, iaculis ac velit a, consectetur pulvinar tortor. Nullam eros diam, vehicula eget elit sit amet, malesuada mattis ante. Phasellus rutrum gravida interdum. Suspendisse ultrices lorem dolor, at laoreet tellus pulvinar a. Phasellus lectus erat, luctus a libero eu, cursus gravida dolor. Quisque id viverra velit. Cras a velit eu lacus venenatis laoreet dapibus quis orci. Donec ornare, tellus sit amet cursus ultrices, quam ipsum sollicitudin neque, a condimentum velit est et lacus. Aenean ut urna pharetra, porta risus sit amet, imperdiet augue. Cras lobortis ex sit amet dolor rutrum dictum. Donec interdum fermentum tempus. Phasellus dignissim ac diam sed ullamcorper. Aenean a est eget dolor posuere malesuada. Aliquam ut dolor quis sem bibendum gravida.";

            string stringaSenzaPunteggiatura = Regex.Replace(stringaDaContare, "(\\p{P})", "");

            string stringaMinuscola = stringaSenzaPunteggiatura.ToLower();

            // Console.WriteLine(stringaSenzaPunteggiatura);

            string[] parole = stringaMinuscola.Split(" ");

            Dictionary<string, int> contoParole = new Dictionary<string, int>();

            for (int i = 0; i < parole.Length; i++)
            {
                string parola = parole[i];

                if (contoParole.ContainsKey(parola))
                {
                    contoParole[parola] = contoParole[parola] + 1;
                } else
                {
                    contoParole[parola] = 1;
                }
            }

            string[] arrayDiChiavi = contoParole.Keys.ToArray();

            for (int i = 0; i < arrayDiChiavi.Length; i++)
            {
                string chiave = arrayDiChiavi[i];

                int valore = contoParole[chiave];

                Console.WriteLine(chiave + " -> " + valore);

            }
        }
    }
}
