namespace OneTwoSystems.ConsoleApp.Classic;

internal class Program
{
	private static void Main(String[] args)
	{
		var zahlenreihe = new List<Int32>
		{
			23, 45, 67, 34, 2
		};

		// zahlenreihe.Add(23);
		// zahlenreihe.Add(45);
		// zahlenreihe.Add(67);
		// zahlenreihe.Add(34);
		// zahlenreihe.Add(2);

		Console.WriteLine("Drehen Sie jetzt am Rad, Q zum Beenden eingeben");
		var eingabe = Console.ReadLine();

		// Das Spiel spielen bis jemand "Q" eingibt.
		// Der String-Vergleich ignoriert dabei Groß- und Kleinschreibung (StringComparison.InvariantCultureIgnoreCase)
		while (!String.Equals(eingabe, "Q", StringComparison.InvariantCultureIgnoreCase))
		// while (eingabe != "Q")
		{
			// Zufallszahlen-Generator erzeugen
			var zufallszahlGenerator = new Random();

			// Zufallszahl generieren, die bei 0 beginnt und höchstens so groß ist
			// wie die Anzahl der Elemente in der Liste.
			// Dabei muss beachtet werden, daß der Index der List bei 0 und nicht
			// bei 1 beginnt, daher wird von "Count" 1 abgezogen.
			var zufallsZahl = zufallszahlGenerator.Next(0, zahlenreihe.Count - 1);

			// Das Element mit dem angegebenen Index aus der Liste holen.
			var Würfelergebnis = zahlenreihe[zufallsZahl];

			// Das Würfelergenis ausgeben.
			Console.WriteLine($"Sie haben {Würfelergebnis} gewürfelt.");

			// Solange weiterspielen, bis einer keinen Bock mehr hat.
			Console.WriteLine("Drehen Sie jetzt am Rad, Q zum Beenden eingeben");
			eingabe = Console.ReadLine();
		}
	}
}
