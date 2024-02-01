namespace YourFirstStatement
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool hasDog = true;

            Console.WriteLine("Do I have to walk the doge?");

            // This writeline on line 14 ONLY happens if hasDog is true
            if (hasDog == true)
            {
                Console.WriteLine("Yup, I sure do!");
            }
        }
    }
}