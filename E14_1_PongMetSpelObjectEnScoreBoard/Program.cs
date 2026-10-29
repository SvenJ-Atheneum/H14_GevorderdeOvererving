// E14.1 - Pong met SpelObject en ScoreBoard  [ESSENTIAL]
//
// Bouw de volledige abstracte SpelObject-hiërarchie en voeg een scorebord toe aan Pong.
// Vereisten:
//   - Abstracte basisklasse SpelObject: voorzie properties X en Y, en een abstracte methode void
//     TekenOpScherm().
//   - Klasse Balletje : SpelObject:
//     - Voeg extra properties VX en VY toe.
//     - Voeg een virtual methode Update() toe.
//     - Override TekenOpScherm().
//   - Klasse CentreerBalletje : Balletje:
//     - Override Update() en roep hierin base.Update() aan.
//   - Klasse ScoreBoard : SpelObject:
//     - Voeg properties ScoreSpeler1 en ScoreSpeler2 toe.
//     - Override TekenOpScherm() en gebruik hierbij ConsoleColor om de score in kleur te tonen.
//   - Spelelementen verzamelen: maak een List<SpelObject> genaamd spelElementen aan met daarin
//     meerdere Balletjes (en/of CentreerBalletjes) samen met het ScoreBoard.
//   - Tekenen: loop met een foreach over spelElementen en roep voor elk element TekenOpScherm() aan.
//   - Type-check: gebruik een is-check (if (spelObject is Balletje bal) bal.Update();) om enkel de
//     balletjes te updaten binnen de loop.
//   - Simulatie: simuleer 200 frames. Verhoog telkens ScoreSpeler1 wanneer een bal de linkerrand
//     raakt.

namespace E14_1_PongMetSpelObjectEnScoreBoard
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // TODO: schrijf hier je code
        }
    }
}
