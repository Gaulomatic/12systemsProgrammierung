using System.Drawing;
using System.Text;

namespace OneTwoSystems.ConsoleApp.Classic;

internal class Program
{
	private static void Main(String[] args)
	{
		var sparschwein = new Sparschwein();
		var jungerFriseur = new HairDresser();

		jungerFriseur.Age = 17;
		jungerFriseur.Name = "Leopold";

		var chef = new HairDresser();

		chef.Age = 53;
		chef.Name = "Hans-Dieter von Deppenstedt";

		var cooleFrisur = new Haircut(sparschwein);

		cooleFrisur.Length = 1;
		cooleFrisur.Color = Color.Blue;
		cooleFrisur.HairDresser = jungerFriseur;
		cooleFrisur.Price = 123.77;

		cooleFrisur.Pay(chef, 150);

		// var langweiligeFrisur = new Haircut(sparschwein);
		var langweiligeFrisur = new Haircut();

		langweiligeFrisur.Length = 3;
		langweiligeFrisur.Color = Color.Gray;
		langweiligeFrisur.HairDresser = chef;
		langweiligeFrisur.Price = 33.66;

		langweiligeFrisur.Pay(chef, 250);

		langweiligeFrisur.CancelPayment();

		// langweiligeFrisur.
	}

	private void AskForAge()
	{
		Console.WriteLine("Wie alt bist Du?");

		var alter = Console.ReadLine();

		var stringBuilder = new StringBuilder();

		stringBuilder.Append("Cool, daß Du es soweit geschafft hast und bereits ");
		stringBuilder.Append(alter);
		stringBuilder.Append(" Jahre alt geworden bist.");

		Console.WriteLine(stringBuilder.ToString());
		Console.WriteLine("Cool, daß Du es soweit geschafft hast und bereits " + alter + " Jahre alt geworden bist.");
		Console.WriteLine($"Cool, daß Du es soweit geschafft hast und bereits {alter} Jahre alt geworden bist.");
	}
}
