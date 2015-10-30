using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


//1.	Berechnen Sie den IBAN für eine Kontonummer und Bankleitzahl
//Beispiel:
//Kontonummer: 31032027080
//BLZ: 11000
//IBAN(Resultat): AT291100031032027080


namespace CodingChallengeWien.Challenges
{
    class Challenge01
    {
        public static string IbanBerechnung(string kontonummer, string blz, bool groupedReturn = true)
        {
            string ibanTemp = blz.PadLeft(5, '0') + kontonummer.PadLeft(11, '0');
            string summe = ibanTemp + "AT".Aggregate("", (current, c) => current + (c - 55).ToString()) + "00";
            decimal checksum = 98 - (decimal.Parse(summe) % 97);
            string iban = "AT" + checksum.ToString().PadLeft(2, '0') + ibanTemp;

            return iban;

        }

    }
}
