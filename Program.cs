global using static System.Console;


Water water = new();
water.Drink("fazrin");
WriteLine(water.DrinkInternal());

Juice juice = new();

juice.Drink("Drinking Juice");
WriteLine(juice.DrinkInternal());

Singleton obj = Singleton.Instance();
obj.name = "Fazrin";
obj.DoThis();

Singleton obj2 = Singleton.Instance();
obj2.name = "Farook";
obj2.DoThis();

obj.DoThis();


internal class Water
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

internal class Juice : Water
{
    public void Make()
    {
        WriteLine("Add juice powder");
    }
}


internal class Tea : Water
{
    public void Make()
    {
        WriteLine("Add Milk + Tea");
    }
}

public sealed class Singleton
{
    public string? name { get; set; }
    private static Singleton _instance;
    private Singleton() { }

    public static Singleton Instance()
    {
        return _instance ??= new Singleton();
    }

    public void DoThis()
    {
        WriteLine("I am object : " + name );
    }
}



