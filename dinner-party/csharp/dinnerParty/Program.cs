Main();

void Main()
{
    List<Guest> GuestList = new List<Guest>();
    GuestList.Add(new Guest("Marilyn Monroe", "entertainer", "(1926 - 1962) American actress, singer, model"));
    GuestList.Add(new Guest("Abraham Lincoln", "politician", "(1809 - 1865) US President during American civil war"));
    GuestList.Add(new Guest("Martin Luther King", "activist", "(1929 - 1968)  American civil rights campaigner"));
    GuestList.Add(new Guest("Rosa Parks", "activist", "(1913 - 2005)  American civil rights activist"));
    GuestList.Add(new Guest("Peter Sellers", "entertainer", "(1925 - 1980) British actor and comedian"));
    GuestList.Add(new Guest("Alan Turing", "computer scientist", "(1912 - 1954) - British computing pioneer, Turing machine, algorithms, cryptology, computer architecture, saved the world"));
    GuestList.Add(new Guest($@"Admiral Grace Hopper", "computer scientist", "(1906–1992) - developed early compilers: FLOW-Matic, COBOL; worked on UNIVAC; gave speeches on computer history, where she gave out nano-seconds"));
    GuestList.Add(new Guest("Indira Gandhi", "politician", "(1917 - 1984) Prime Minister of India 1966 - 1977"));

    List<Guest> Table1 = GuestList.DistinctBy(guest => guest.Occupation).ToList();
    List<Guest> Table2 = new List<Guest>();

    foreach(Guest guest in GuestList)
    {
        if(!Table1.Contains(guest))
        {
            Table2.Add(guest);
        }
    }

    TableList("Table 1", Table1);
    TableList("Table 2", Table2);
}

void TableList(string tableNumber, List<Guest> table)
{
    Console.WriteLine($"{tableNumber}:");
    foreach(Guest seatedGuest in table)
    {
        Console.WriteLine($"{seatedGuest.Name}, {seatedGuest.Occupation}");
        Console.WriteLine(seatedGuest.Bio);
    }
}

public class Guest
{
    public string Name
    { get; set; }

    public string Occupation
    { get; set; }

    public string Bio
    { get; set; }

    public Guest(string name, string occupation, string bio)
    {
        Name = name;
        Occupation = occupation;
        Bio = bio;
    }

    public string getOccupation
    { 
        get{return Occupation;} 
    }
}

