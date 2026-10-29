// B14.2 - Abstracte klasse GeometrischeFiguur  [BASIS]
//
// Implementeer een abstracte klassenhiërarchie voor geometrische figuren.
// Vereisten:
//   - Abstracte klasse GeometrischeFiguur: voorzie een abstract methode double BerekenOppervlakte(),
//     een abstract methode double BerekenOmtrek() en een abstract property string Naam { get; }.
//   - Voeg een gewone (niet-abstracte) methode ToonInfo() toe die Naam, oppervlakte en omtrek netjes
//     toont.
//   - Child-klasse Cirkel:
//     - Voeg een property Straal toe.
//     - Override de oppervlakteberekening (PI * r * r).
//     - Override de omtrekberekening (2 * PI * r).
//   - Child-klasse Rechthoek:
//     - Voeg properties Breedte en Hoogte toe.
//     - Override de oppervlakteberekening (B * H).
//     - Override de omtrekberekening (2 * (B + H)).
//   - Child-klasse DrieHoek:
//     - Voeg properties Basis, Hoogte, Zijde1, Zijde2 en Zijde3 toe.
//     - Override de oppervlakteberekening (B * H / 2).
//     - Override de omtrekberekening (som van de drie zijden).
//   - Testen: maak een List<GeometrischeFiguur> aan met een mix van Cirkel, Rechthoek en DrieHoek.
//     Roep via een foreach-lus voor elke figuur ToonInfo() op.
//   - Aantonen: toon aan (bijvoorbeeld in commentaar of via een poging in je code) dat new
//     GeometrischeFiguur() een compilatiefout geeft.

namespace B14_2_AbstracteKlasseGeometrischeFiguur
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // TODO: schrijf hier je code
        }
    }
}
