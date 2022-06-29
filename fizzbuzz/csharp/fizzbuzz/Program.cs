Main();

void Main()
{
    Console.WriteLine("Enter a number 1-100");

    string intString = Console.ReadLine();

    int.TryParse(intString, out int i);

    if (i % 15 == 0)
    {
        Console.WriteLine("fizzbuzz");
    }
    else if (i % 3 == 0) 
    {
        Console.WriteLine("fizz");
    }
    else if (i % 5 == 0)
    {
        Console.WriteLine("buzz");
    }
    else
    {
        Console.WriteLine(i);
    }
}