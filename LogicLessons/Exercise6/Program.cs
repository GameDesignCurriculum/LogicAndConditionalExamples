using System;

namespace Exercise7
{
    class Program
    {
        static void Main(string[] args)
        {
            bool doorLocked = true;
            int triesLeft = 3;
            const string correctPassword = "oP3nSesaME!";

            Console.WriteLine("You are standing in front of a locked door.  There is a sign that says, you must provide the correct password to enter.");
            
            // Loop until the door is unloced or the player has tried 3 times.
            while (doorLocked && triesLeft > 0 )
            {
                // Decrement the number of tries remaining
                triesLeft--;

                // Do Not change code above this line.  Add your code below

                // Add code to prompt for and get user's password.




                //Check if the password is correct or not







                // Do not change code below this line

            }
        }
    }
}
