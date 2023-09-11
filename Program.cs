//Tom Ellner NET23
namespace MyFirstProgram
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Declares and initializes an integer variable 'variable' with the value 4.
            int variable = 4;
            //Uses an if statement to check whether 'variable' is greater than 10 and prints a message accordingly.
            if (variable > 10)
            {
                Console.WriteLine("Talet är stort!");
            }
            else
            {
                Console.WriteLine("Oj. Lågt tal!");
            }

            //Asks the user for their name and stores the input in the 'name' variable, then greets the user.
            Console.WriteLine("Vad heter du?");
            string name = Console.ReadLine();
            Console.WriteLine($"Hej {name}!");

            //Uses a for loop to print numbers from 0 to 'variable' (which is 4 in this case).
            for (int i = 0; i <= variable; i++)
            {
                Console.WriteLine(i);
            }
        }
    }
}