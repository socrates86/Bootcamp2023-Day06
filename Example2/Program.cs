namespace Example2;

class Program
{
    static Void Main(string[] args)
    {
        Console.WriteLine("Which from the options below is your favourite continent?");
        console.WriteLine("1. Africa \n2. North America \n3. Asia \n4. Europe");
        int? choice = Convert.ToLower(Console.ReadLine());
    }   

    switch (choice)
    {
        case 1 :
        Console.WriteLine("Halo Africa, you're great!");
        break;

        case 2 :
        Console.WriteLine("Halo North America, what's going on?");
        break;

        case 3 :
        Console.WriteLine("Halo Asia, make peace with your opposition now");
        break;

        case 4 :
        Console.WriteLine("Halo Europe, what's up with you?");
        break; 

        default:
        Console.WriteLine("Halo, please provide a known option.");
        break;
    }
}