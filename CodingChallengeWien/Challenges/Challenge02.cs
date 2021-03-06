﻿using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//2.	Erstellen Sie eine Funktion, die überprüft, ob der übergebene String eine gültige Mac Adresse ist(Beispiel: 00-80-41-ae-fd-7e oder 00:80:41:ae:fd:7e).
//Tipp: https://de.wikipedia.org/wiki/MAC-Adresse#Form_.28Syntax.29_von_MAC-Adressen


namespace CodingChallengeWien.Challenges
{
    class Challenge02
    {
        internal static bool MacBerechnung(string macAdresse)
        {
            var expression = @"(([a-f]|[0-9]|[A-F]){2}[-\:]){5}([a-f]|[0-9]|[A-F]){2}\b";
            return System.Text.RegularExpressions.Regex.IsMatch(macAdresse, expression);
        }
    }
}
