// P14.1 - RPG uitgebreid met abstracte SpelEntiteit  [PRO]
//
// Herwerk het RPG-systeem uit H13 met een abstracte basisklasse SpelEntiteit.
// Vereisten:
//   - Abstracte klasse SpelEntiteit: voorzie properties Naam, HP en Level. Voeg een abstract methode
//     string Beschrijving() toe.
//   - Voeg een abstract methode void Aanval(SpelEntiteit doel) toe.
//   - Voeg een virtual methode void Verdedig() toe.
//   - Voeg een virtual methode void LevelUp() toe.
//   - Override ToString(): deze roept Beschrijving() aan.
//   - Child-klasse Karakter : SpelEntiteit: voeg extra properties MP, Kracht en Magie toe.
//   - Child-klasse Strijder : Karakter:
//     - Voeg extra properties Wapenbonus en WapenType (enum) toe.
//     - Override Aanval() zodat deze fysiek gericht is, gebaseerd op Kracht en Wapenbonus.
//   - Child-klasse Tovenaar : Karakter:
//     - Voeg extra properties SpellMP en SpellLijst (List<string>) toe.
//     - Override Aanval() zodat deze magisch gericht is, gebaseerd op Magie.
//   - Abstracte klasse Omgeving: voorzie properties Naam en Bewoners (List<SpelEntiteit>). Voeg een
//     abstract methode void BetreedOmgeving() toe.
//   - Child-klasse Dungeon : Omgeving, child-klasse Dorp : Omgeving en child-klasse Kasteel :
//     Omgeving: elk met een eigen invulling van BetreedOmgeving() (bijvoorbeeld een korte
//     sfeerboodschap + de bewoners tonen).
//   - Bewoners aanmaken: vul de Bewoners-lijst van elke omgeving met willekeurig gegenereerde
//     SpelEntiteiten. Gebruik de klasse Random om voor elke bewoner het Level (en op basis daarvan de
//     overige stats, zoals HP) willekeurig te bepalen, zodat elke speelsessie een andere samenstelling
//     van vijanden oplevert.
//   - Dungeonspel:
//     - De speler kiest aan het begin één omgeving (Dungeon, Dorp of Kasteel) uit een menu.
//     - De speler strijdt vervolgens beurt-per-beurt tegen elke bewoner van die omgeving (HP-balken
//       tonen na elke beurt, gevecht eindigt zodra één partij op 0 HP komt).
//   - Scoresysteem: de score die de speler krijgt per verslagen bewoner is afhankelijk van het Level
//     van die bewoner (bijvoorbeeld Level × 10 punten), zodat sterkere vijanden meer score opleveren.
//     De totaalscore wordt getoond zodra alle bewoners van de gekozen omgeving verslagen zijn of de
//     speler zelf verliest.
// Testen: maak een Strijder en een Tovenaar aan, kies een omgeving met een aantal willekeurig
// aangemaakte bewoners, en speel het Dungeonspel helemaal uit tot het einde (win of verlies), met de
// uiteindelijke score zichtbaar op het einde.

namespace P14_1_RPGUitgebreidMetAbstracteSpelEntiteit
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // TODO: schrijf hier je code
        }
    }
}
