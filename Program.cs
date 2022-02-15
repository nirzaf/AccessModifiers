global using static System.Console;


Water water = new();

water.Drink("fazrin");
WriteLine(water.DrinkInternal());

Juice juice = new();

juice.Drink("Drinking Juice");
WriteLine(juice.DrinkInternal());

public class Water
{
    public void Drink(string name)
    {
        Drink();
        WriteLine(name + "is drinking water!");
    }

    private void Drink()
    {
        WriteLine("Drinking water!");
    }


    protected string DrickProtected()
    {
        return "Protected Drinking water!";
    }

    internal string DrinkInternal()
    {
        return "Internal Drinking water!";
    }
}

public class Juice : Water
{
    public void Make()
    {
        WriteLine("Add juice powder");
    }
}
