static void Main(string[] args)
{ 
	double bulletDiameter, landDiameter, neckDiameter, baseDiameter;
	while (true)
	{
		Bird bird;
		Console.Write("\nPress P for pigeon, 0 for ostrich, V for vulture: ");
		char key = Char.ToUpper(Console.ReadKey().KeyChar);
		if (key == 'P') bird = new Pigeon();
		if (key == 'V') bird = new Vulture();
		else if (key == 'O') bird = new Ostrich();
		else return;
		Console.Write("\nHow many eggs should it lay? ");
		if(!int.TryParse(Console.ReadLine(), out int numberOfEggs)) return;
		Egg[] eggs = bird.LayEggs(numberOfEggs);
		foreach (Egg egg in eggs)
		{
			Console.WriteLine(egg.Description);
		}
	}
}

class Egg
{
	public double Size { get; private set; }
	public string Color { get; private set; }
	public Egg(double size, string color)
	{
		Size = size;
		Color = color;
	}
	public string Description {
		get { return $"A {Size:0.0} cm {Color} egg"; }
	}
}

class Weapon
{
	String[] HandgunWeapons;
	int count;
	public categorizeWeapon(String typeOfWeapon)
	{
		HandgunWeapons[count] = typeOfWeapon;
		count++;
	}
}

class NineMM : Weapon
{
	if(bulletDiameter == 9.01)
		if(landDiameter	== 8.82)
			if(neckDiameter == 9.65)
				if(baseDiameter == 9.93) {
					String Gun = "9mm";
					categorizeWeapon(Gun);
				}
}

class Bird
{
	public static Random Randomizer = new Random();
	public virtual Egg[] LayEggs(int numberOfEggs)
	{
		Console.Error.WriteLine("Bird.LayEggs should never get called");
		return new Egg[0];
	}
}

class Pigeon : Bird 
{
	public override Egg[] LayEggs(int numberOfEggs)
	{
		Egg[] eggs = new Egg[numberOfEggs];
		for (int i = 0; i < numberOfEggs; i++)
		{
			eggs[i] = new Egg(Bird.Randomizer.NextDouble() * 2 + 1, "white");
		}
		return eggs;
	}
}

class Ostrich : Bird
{
	public override Egg[] LayEggs(int numberOfEggs)
	{
		Egg[] eggs = new Egg[numberOfEggs];
		for (int i = 0; i < numberOfEggs; i++)
		{
			eggs[i] = new Egg(Bird.Randomizer.NextDouble() + 12, "speckled");
		}
		return eggs;
	}
}

class Vulture : Bird
{
	public override Egg[] LayEggs(int numberOfEggs)
	{
		Egg[] eggs = new Egg[numberOfEggs];
		for (int i = 0; i < numberOfEggs; i++)
		{
			eggs[i] = new Egg(Bird.Randomizer.NextDouble() * 6 + 3, "green && blue");
		}
		return eggs;
	}
}
