using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zahlensystemumrechner7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Willkommen zum Zahlensystemumrechner!");

            // Benutzereingabe für die erste Zahl und das Ausgangssystem
            Console.Write("Geben Sie die erste Zahl ein: ");
            string zahl1 = Console.ReadLine();
            Console.Write("Geben Sie das Ausgangssystem der ersten Zahl ein (binär, oktal, dezimal oder hexadezimal): ");
            string ausgangssystem = Console.ReadLine();

            // Benutzereingabe für die zweite Zahl und das Zielssystem
            Console.Write("Geben Sie die zweite Zahl ein: ");
            string zahl2 = Console.ReadLine();
            Console.Write("Geben Sie das Zielssystem der zweiten Zahl ein (binär, oktal, dezimal oder hexadezimal): ");
            string zielssystem = Console.ReadLine();

            // Umrechnen der ersten Zahl ins Dezimalsystem
            int dezimal1 = Zahlensystem.UmwandelnInDezimal(zahl1, ausgangssystem);

            // Umrechnen der zweiten Zahl ins Dezimalsystem
            int dezimal2 = Zahlensystem.UmwandelnInDezimal(zahl2, zielssystem);

            // Durchführen der Rechenoperationen
            Console.WriteLine($"Ergebnis der Addition: {Zahlensystem.Addition(dezimal1, dezimal2)}");
            Console.WriteLine($"Ergebnis der Subtraktion: {Zahlensystem.Subtraktion(dezimal1, dezimal2)}");
            Console.WriteLine($"Ergebnis der Multiplikation: {Zahlensystem.Multiplikation(dezimal1, dezimal2)}");
            Console.WriteLine($"Ergebnis der Division: {Zahlensystem.Division(dezimal1, dezimal2)}");

            Console.ReadLine();
        }
    }

    class Zahlensystem
    {
        // Methode zur Umwandlung einer Zahl in das Dezimalsystem
        public static int UmwandelnInDezimal(string zahl, string system)
        {
            return Convert.ToInt32(zahl, GetRadix(system));
        }

        // Methode zur Umwandlung einer Zahl vom Dezimalsystem in ein anderes Zahlensystem
        public static string UmwandelnInAnderesSystem(int dezimal, string system)
        {
            return Convert.ToString(dezimal, GetRadix(system));
        }

        // Methode zur Addition zweier Zahlen im Dezimalsystem
        public static int Addition(int zahl1, int zahl2)
        {
            return zahl1 + zahl2;
        }

        // Methode zur Subtraktion zweier Zahlen im Dezimalsystem
        public static int Subtraktion(int zahl1, int zahl2)
        {
            return zahl1 - zahl2;
        }

        // Methode zur Multiplikation zweier Zahlen im Dezimalsystem
        public static int Multiplikation(int zahl1, int zahl2)
        {
            return zahl1 * zahl2;
        }

        // Methode zur Division zweier Zahlen im Dezimalsystem
        public static int Division(int zahl1, int zahl2)
        {
            if (zahl2 == 0)
            {
                Console.WriteLine("Division durch Null ist nicht erlaubt!");
                return 0;
            }
            return zahl1 / zahl2;
        }

        // Hilfsmethode zur Bestimmung des Zahlensystems
        private static int GetRadix(string system)
        {
            switch (system.ToLower())
            {
                case "binär":
                    return 2;
                case "oktal":
                    return 8;
                case "dezimal":
                    return 10;
                case "hexadezimal":
                    return 16;
                default:
                    Console.WriteLine("Ungültiges Zahlensystem!");
                    return 0;
            }
        }
    }
}
