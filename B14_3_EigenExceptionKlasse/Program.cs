// B14.3 - Eigen exception-klasse  [BASIS]
//
// Bouw een eigen exception-hiërarchie voor een bankrekening-systeem.
// Vereisten:
//   - Exceptionklasse BankException : Exception: voorzie een extra property Context (string).
//   - Exceptionklasse OnvoldoendeSaldoException : BankException: voorzie een extra property Tekort
//     (double).
//   - Exceptionklasse OngeldigeTransactieException : BankException: voorzie een extra property Bedrag
//     (double).
//   - Klasse BankRekening: voorzie properties Saldo en Naam, en de methoden Stort en Hef.
//   - Stort: gooi een OngeldigeTransactieException als het bedrag <= 0 is.
//   - Hef: gooi een OnvoldoendeSaldoException als saldo < bedrag, waarbij je Tekort instelt op bedrag
//     - saldo.

namespace B14_3_EigenExceptionKlasse
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // TODO: schrijf hier je code
        }
    }
}
