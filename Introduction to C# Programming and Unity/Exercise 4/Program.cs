namespace Exercise4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter your first location.");

            string location1 = Console.ReadLine();

            Console.WriteLine("Enter the altitude of your first location, in feet.");

            int altitude1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter your second location.");

            string location2 = Console.ReadLine();

            Console.WriteLine("Enter the altitude of your second location, in feet.");

            int altitude2 = int.Parse(Console.ReadLine());

            Console.WriteLine("The difference in altitude between " + location1 + " and "
                + location2 + " is " + MathF.Abs(altitude1 - altitude2) + "ft.");
        }
    }
}