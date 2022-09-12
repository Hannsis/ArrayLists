namespace Arrays__lists__for_and_foreach
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Arrays are used to store multiple values in a single variable,
            //instead of declaring separate variables for each value.
            Array();

        }

        static void Array()
        {
            string [] cuteAnimals = new string[3];
            cuteAnimals[0] = "kitten";
            cuteAnimals[1] = "cow";
            cuteAnimals[2] = "puppy";
            Console.WriteLine($"Oh look at that adorable {cuteAnimals[1]}");

            string[] uncuteAnimals = { "spider", "cockroach", "marulk","rollie pollie" };
            Console.WriteLine($"ett äckligt djur är: {uncuteAnimals[2]}");

            string[] sötDjur = new string[3];
            Console.WriteLine("Skriv in tre djur som du tycker är söta");
            sötDjur[0] = Console.ReadLine();
            sötDjur[1] = Console.ReadLine();
            sötDjur[2] = Console.ReadLine();
            Console.WriteLine($"tre sjur du gillar är: {sötDjur[2]}, {sötDjur[1]} och {sötDjur[0]}");
        }

        static void Städer() 
        {
            string[] svenskaStäder = new string[];
            Console.WriteLine("Skriv in en stad:");
            svenskaStäder[0] = "Göteborg";
            svenskaStäder[1] = "Malmö";
            svenskaStäder[2] = "Stockholm";
            svenskaStäder[3] = Console.ReadLine();
            Console.WriteLine($"Här är yttligare 3 svenska städer: {svenskaStäder[0]}, {svenskaStäder[1]} och {svenskaStäder[2");
            
        }
    }

}