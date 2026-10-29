// P14.2 - Reporting framework met abstract + eigen exceptions  [PRO]
//
// Bouw een rapporteringssysteem dat abstracte klassen en eigen exceptions combineert.
// Vereisten:
//   - Abstracte klasse Rapport: voorzie properties Titel en Datum. Voeg een abstracte methode string
//     GenereerInhoud() toe. Override de methode ToString().
//   - Abstracte klasse RapportRenderer: voeg een abstracte methode void Render(Rapport r) toe.
//   - Child-klasse TextRenderer : RapportRenderer:
//     - Implementeer Render() zodat deze de tekst van het rapport toont in de console.
//   - Child-klasse HtmlRenderer : RapportRenderer:
//     - Implementeer Render() zodat deze een HTML-string genereert van het rapport.
//   - Child-klasse VerkooprRapport : Rapport:
//     - Voeg een property List<Verkooplijn> toe.
//     - Override GenereerInhoud().
//   - Child-klasse FinancieelRapport : Rapport:
//     - Voeg properties Inkomsten en Uitgaven toe.
//     - Override GenereerInhoud().
//   - Exceptions: maak een eigen basis-exceptionklasse RapportException : Exception, en laat daarvan
//     RendererException en NullInhoudException overerven.
//   - RapportService: beheer een lijst van rapporten, en voorzie functionaliteit om rapporten te
//     genereren en te renderen via de abstracte Rapport- en RapportRenderer-klassen.

namespace P14_2_ReportingFrameworkMetAbstractEigenExceptions
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // TODO: schrijf hier je code
        }
    }
}
