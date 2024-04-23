using System;

namespace Zahlensystemumrechner
{
    public class NummerSystem
    {
        private string value;
        private int baseValue;

        public NummerSystem(string value, int baseValue)
        {
            this.value = value.ToUpper();
            this.baseValue = baseValue;
        }

        public string GetValue()
        {
            return value;
        }

        public string ToBinary()
        {
            return Convert.ToString(Convert.ToInt32(value, baseValue), 2);
        }

        public string ToOctal()
        {
            return Convert.ToString(Convert.ToInt32(value, baseValue), 8);
        }

        public string ToDecimal()
        {
            return Convert.ToInt32(value, baseValue).ToString();
        }

        public string ToHexadecimal()
        {
            return Convert.ToString(Convert.ToInt32(value, baseValue), 16);
        }

        public static NummerSystem operator +(NummerSystem num1, NummerSystem num2)
        {
            int ergebnis = Convert.ToInt32(num1.value, num1.baseValue) + Convert.ToInt32(num2.value, num2.baseValue);
            return new NummerSystem(ergebnis.ToString(), 10);
        }

        public static NummerSystem operator -(NummerSystem num1, NummerSystem num2)
        {
            int ergebnis = Convert.ToInt32(num1.value, num1.baseValue) - Convert.ToInt32(num2.value, num2.baseValue);
            return new NummerSystem(ergebnis.ToString(), 10);
        }

        public static NummerSystem operator *(NummerSystem num1, NummerSystem num2)
        {
            int ergebnis = Convert.ToInt32(num1.value, num1.baseValue) * Convert.ToInt32(num2.value, num2.baseValue);
            return new NummerSystem(ergebnis.ToString(), 10);
        }

        public static NummerSystem operator /(NummerSystem num1, NummerSystem num2)
        {
            int ergebnis = Convert.ToInt32(num1.value, num1.baseValue) / Convert.ToInt32(num2.value, num2.baseValue);
            return new NummerSystem(ergebnis.ToString(), 10);
        }

        class Start
        {
            static void Main(string[] args)
            {
                Console.WriteLine("Willkommen zum Zahlensystemumrechner!");

                Console.Write("Geben Sie die erste Zahl ein: ");
                string zahl1 = Console.ReadLine();

                Console.Write("Geben Sie die Basis der ersten Zahl ein: ");
                int basis1 = Convert.ToInt32(Console.ReadLine());

                Console.Write("Geben Sie die zweite Zahl ein: ");
                string zahl2 = Console.ReadLine();

                Console.Write("Geben Sie die Basis der zweiten Zahl ein: ");
                int basis2 = Convert.ToInt32(Console.ReadLine());

                if (basis1 < 2 || basis1 > 16 || basis2 < 2 || basis2 > 16)
                {
                    Console.WriteLine("Ungültige Basis. Die Basis muss zwischen 2 und 16 liegen.");
                    Console.WriteLine("Das Programm wird beendet.");
                    return;
                }

                NummerSystem num1 = new NummerSystem(zahl1, basis1);
                NummerSystem num2 = new NummerSystem(zahl2, basis2);

                NummerSystem sum = num1 + num2;
                NummerSystem difference = num1 - num2;
                NummerSystem product = num1 * num2;
                NummerSystem quotient = num1 / num2;

                Console.WriteLine("Addition: " + sum.GetValue());
                Console.WriteLine("Subtraktion: " + difference.GetValue());
                Console.WriteLine("Multiplikation: " + product.GetValue());
                Console.WriteLine("Division: " + quotient.GetValue());

                Console.WriteLine("Binär: " + num1.ToBinary());
                Console.WriteLine("Oktal: " + num1.ToOctal());
                Console.WriteLine("Dezimal: " + num1.ToDecimal());
                Console.WriteLine("Hexadezimal: " + num1.ToHexadecimal());

                Console.WriteLine("Drücken Sie eine Taste, um das Programm zu beenden...");
                Console.ReadKey();
            }
        }
    }
}
