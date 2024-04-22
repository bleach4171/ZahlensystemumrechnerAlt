class Zahlensystem
{
    // Methode zur Umwandlung einer Zahl in das Dezimalsystem
    public static int UmwandelnInDezimal(string zahl, string system)
    {
        switch (system.ToLower())
        {
            case "binär":
                return Convert.ToInt32(zahl, 2);
            case "oktal":
                return Convert.ToInt32(zahl, 8);
            case "dezimal":
                return Convert.ToInt32(zahl, 10);
            case "hexadezimal":
                return Convert.ToInt32(zahl, 16);
            default:
                Console.WriteLine("Ungültiges Zahlensystem!");
                return 0;
        }
    }

    // Methode zur Umwandlung einer Zahl vom Dezimalsystem in ein anderes Zahlensystem
    public static string UmwandelnInAnderesSystem(int dezimal, string system)
    {
        switch (system.ToLower())
        {
            case "binär":
                return Convert.ToString(dezimal, 2);
            case "oktal":
                return Convert.ToString(dezimal, 8);
            case "dezimal":
                return Convert.ToString(dezimal, 10);
            case "hexadezimal":
                return Convert.ToString(dezimal, 16);
            default:
                Console.WriteLine("Ungültiges Zahlensystem!");
                return "";
        }
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
}
