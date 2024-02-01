namespace IfElseStatement
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool hasDog = true;

            Console.WriteLine("Do I have to walk the dog?");

            // This writeline on line 14 ONLY happens if hasDog is true
            if (hasDog == true)
            {
                Console.WriteLine("Yup, I sure do!");
            }
            else   // Otherwise, the writeline on line 20 happens
            {
                Console.WriteLine("Nope. I don't have a dog!");
            }
        }
    }
}