namespace hw_cSH_15;

public class Magazine
{
    public string Name { get; set; }
    public string NameEstablishment { get; set; }
    public DateOnly DatePublication { get; set; }
    public uint CountPage { get; set; }

    public Magazine(string name, string nameEstablishment, DateOnly date, uint countPage)
    {
        Name = name;
        NameEstablishment = nameEstablishment;
        DatePublication =  date;
        CountPage = countPage;
    }

    public static Magazine CreateMagazine()
    {
        Console.WriteLine("Name Magazine");
        string name = Console.ReadLine();
        
        Console.WriteLine("Name Establishment");
        string nameEstablishment = Console.ReadLine();

        Console.WriteLine("Publish date (MM.dd.yyyy) or press Enter for today date");
        DateTime date;
        try
        {
            date = DateTime.Parse(Console.ReadLine());
        }
        catch (Exception e)
        {
            Console.WriteLine(e.Message);
            date = DateTime.Today;
        }

        Console.WriteLine("Count pages");
        uint pages;
        try
        {
            pages = uint.Parse(Console.ReadLine());
        }
        catch (Exception e)
        {
            Console.WriteLine(e.Message);
            pages = 0;
        }

        return new Magazine(name, nameEstablishment, DateOnly.FromDateTime(date), pages);
    }

    public override string ToString() => $"{Name}, {NameEstablishment}, {DatePublication}, Pages:{CountPage}";
}