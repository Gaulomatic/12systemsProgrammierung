namespace OneTwoSystems.ConsoleApp.Classic;

public class Sparschwein
{
	public Double Amount { get; private set; }

	public void Add(Double value)
	{
		this.Amount += value;
	}

	public void Remove(Double value)
	{
		var newAmount = this.Amount - value;

		if (newAmount < 0)
		{
			throw new Exception("Du kannst nicht mehr aus dem Sparschwein entnehmen als enthalten ist.");
		}

		this.Amount = newAmount;
	}
}
