namespace Example1;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("What is your fvourite continent?");
        string? choice = Console.ReadLine();
        choice = choice?.ToLower();

        const string Africa = "africa";
        const string Asia = "asia";
        const string SouthAmerica = "southamerica";
        const string Europe = "europe";
        const string NorthAmerica = "northamerica";

        switch(choice)
        {
            case Africa :
            Console.WriteLine("Halo Africa, you're in deed blessed!");
            break;

            case Asia :
            Console.WriteLine("Halo Asia, how do you do today?");
            break;

            case SouthAmerica :
            Console.WriteLine("Halo SouthAmerica, what's up with you?");
            break;

            case  Europe :
            Console.WriteLine("Halo Europe, I love you!");
            break;

            case NorthAmerica :
            Console.WriteLine("Halo NorthAmerica, you have evrything it takes.");
            break;

            default :
            Console.WriteLine("Please choose a known option");
            break;
        }
    }
}