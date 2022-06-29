Main();

void Main()
{
    List<string> insults = new List<string>{
        "You look like what morning breath smells like.",
        "If you tried to give me cpr I would probably throw myself back under water",
        "I am not a fan of you",
        "You think you're so special...and you are. The fact of your existence is nearly impossible to believe",
        "I'd rather walk than be on the same plane as you",
        "If I were given a million dollars to hang out with you...I would, but then I'd have to spend half of it on therapy",
        "Do you have to be so...like that?"
    };

    // foreach(string insult in insults)
    // {
    //     Console.WriteLine(insult);
    // }

    Random randomInt = new Random();
    int randomInsult = randomInt.Next(0, insults.Count() - 1);

    List<int> indexes = new List<int>{};

    while(indexes.Count() < 3)
    {
        Random candidate = new Random();
        int randomCandidate = candidate.Next(0, insults.Count - 1);

        if(!indexes.Contains(randomCandidate))
        {
            indexes.Add(randomCandidate);
        }
    }

    foreach(int index in indexes)
    {
        Console.WriteLine(insults[index]);
    }

}