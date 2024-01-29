namespace BooleanVariables;
class Program
{
    static void Main(string[] args)
    {

        // Provide menu of options for exercises to run
        Console.WriteLine("Which activity do you want to run? ");
        Console.WriteLine("1. Activity1 - Boolean Variables Example");
        Console.WriteLine("2. Activity2 - Comparison Operators");
        Console.WriteLine("Type the number of the activity to run (or A to run all): ");
        string selection = Console.ReadLine().ToUpper();
        while (selection != null)
        {
            switch (selection)
            {
                case "1":
                    BooleanVariableActivity.Activity1();
                    break;
                case "2":
                    ComparisonOperators.Activity2();
                    break;
                case "Q":
                    break;
                default:
                    Console.WriteLine("Activity 1");
                    BooleanVariableActivity.Activity1();
                    Console.WriteLine();
                    Console.WriteLine("Activity 2");
                    ComparisonOperators.Activity2();
                    break;

            }
            Console.WriteLine("Which activity do you want to run? ");
            Console.WriteLine("1. Activity1 - Boolean Variables Example");
            Console.WriteLine("2. Activity2 - Comparison Operators");
            Console.WriteLine("Type the number of the activity to run (or A to run all, Q to quit): ");
            selection = Console.ReadLine().ToUpper();
            if (selection == "Q")
            { break; }    
        }
    }
}