namespace Exercise6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter an angle in degrees.");

            float angleInDegrees = float.Parse(Console.ReadLine());

            float angleInRadians = angleInDegrees * ((float)Math.PI / 180);

            Console.WriteLine("The sine of the angle is " + Math.Sin((double)angleInRadians));

            Console.WriteLine("The cosine of the angle is " + Math.Cos((double)angleInRadians));
        }
    }
}