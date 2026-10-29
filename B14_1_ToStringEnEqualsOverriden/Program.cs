// B14.1 - ToString() en Equals() overriden  [BASIS]
//
// Override ToString() en Equals() in een bestaande klasse voor zinvolle vergelijking en weergave.
// Vereisten:
//   - Klasse Boek: voorzie properties Titel (string), Auteur (string), ISBN (string, required) en
//     AantalPaginas (int).
//   - Override ToString(): geef een netjes geformatteerde string terug.
//   - Override Equals(object o): twee boeken zijn gelijk als hun ISBN identiek is.
//   - Override GetHashCode(): geef ISBN.GetHashCode() terug.
//   - Demonstreer Console.WriteLine(boek) en toon dat dit een mooi, leesbaar resultaat geeft.
//   - Demonstreer boek1.Equals(boek2) voor zowel een geval met gelijke ISBN als een geval met
//     ongelijke ISBN.
//   - Demonstreer het verschil tussen ReferenceEquals(boek1, boek2) en boek1.Equals(boek2).
//   - Toon via GetType() en GetType().Name het type op het scherm.

namespace B14_1_ToStringEnEqualsOverriden
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // TODO: schrijf hier je code
        }
    }
}
