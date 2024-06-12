public class Country
{
    public string Name { get; set; }
    public string Flag { get; set; }
    public int Population { get; set; }

    public Country(string name, string flag, int population)
    {
        this.Name = name;
        this.Flag = flag;
        this.Population = population;
    }

    public override string ToString()
    {
        return $"Name: {Name}, Flag: {Flag}, Population: {Population}";
    }

}

public class CountryData
{
    public FlagsData flags { get; set; }
    public NameData name { get; set; }
    public int population { get; set; }

}

public class FlagsData
{
    public string png { get; set; }
}

public class NameData
{
    public string common { get; set; }
}