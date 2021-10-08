using System.Drawing;

namespace OneTwoSystems.ConsoleApp.Classic;

public class Haircut
{
	private readonly Sparschwein? sparschwein;

	public Haircut(Sparschwein? sparschwein = null)
	{
		this.sparschwein = sparschwein;
	}

	public String CustomerName { get; set; }
	public Int32 Length { get; set; }
	public Double Price { get; set; }
	public HairDresser HairDresser { get; set; }
	public HairDresser Cashier { get; set; }
	public Boolean IsPayed { get; private set; }
	public Color Color { get; set; }

	public void Pay(HairDresser cashier, Double amountPayed)
	{
		if (amountPayed < this.Price)
		{
			throw new Exception("Der bezahlte Betrag liegt unter dem Preis der Frisur");
		}

		if (amountPayed > this.Price)
		{
			var difference = amountPayed - this.Price;

			// this.sparschwein?.Add(difference);

			if (this.sparschwein is not null)
			{
				this.sparschwein.Add(difference);
			}
		}

		this.Cashier = cashier;
		this.IsPayed = true;
	}

	public void CancelPayment()
	{
		this.IsPayed = false;
		this.Price += 60;
	}
}
