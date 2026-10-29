// E14.2 - Abstracte dierenhiërarchie met interface-preview  [ESSENTIAL]
//
// Bouw een abstracte dierenhiërarchie met abstracte methoden, eigen exceptions en ToString().
// Vereisten:
//   - Abstracte basisklasse Dier: voorzie properties Naam en Gewicht. Voeg een abstracte methode
//     string MaakGeluid() toe en een abstracte methode string Voedsel() toe.
//   - Override ToString(): toon hierin alle info van het dier netjes geformatteerd.
//   - Voeg een abstracte property bool KanZwemmen { get; } toe.
//   - Child-klasse Hond : Dier:
//     - Voeg een extra property Ras toe.
//     - Override alle abstracte leden (MaakGeluid, Voedsel, KanZwemmen).
//   - Child-klasse Kat : Dier:
//     - Voeg een extra property IsKamerkat toe.
//     - Override alle abstracte leden.
//   - Child-klasse Vis : Dier:
//     - Voeg een extra property Diepte toe.
//     - Override alle abstracte leden.
//   - Maak een eigen exceptionklasse DierNietGevondenException : Exception.
//   - Klasse Dierentuin: voorzie een List<Dier> en de methoden VoegToe, ZoekOpNaam (deze moet
//     DierNietGevondenException gooien als het dier niet gevonden wordt) en ToonAlle.
//   - Overzicht: toon alle dieren waarvoor KanZwemmen == true.

namespace E14_2_AbstracteDierenhierarchieMetInterfacePreview
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // TODO: schrijf hier je code
        }
    }
}
