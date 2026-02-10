using System.Net.Quic;
using System.Security.Cryptography.X509Certificates;

namespace Topic_4._5___Methods_Assignment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string choice = "";

            while (choice != "q")
            {
                Console.WriteLine();
                Console.WriteLine("Welcome! Which one of the choices below would you like to see?");
                Console.WriteLine();
                Console.WriteLine("1 - Art");
                Console.WriteLine("or");
                Console.WriteLine("2 - Knock knock joke");
                Console.WriteLine();
                choice = Console.ReadLine().ToLower().Trim();
                Console.WriteLine();
                Console.Clear();

                if (choice == "1")
                {
                    Console.WriteLine("      ,*-.");
                    Console.WriteLine("      |  |");
                    Console.WriteLine("  ,.  |  |");
                    Console.WriteLine("  | |_|  | ,.");
                    Console.WriteLine("  `___.  |_| |");
                    Console.WriteLine("      |  .--`");
                    Console.WriteLine("      |  |");
                    Console.WriteLine("      |  |");
                    Console.WriteLine();
                    Console.WriteLine("Press Enter to see the next one");
                    Console.ReadLine();
                    Console.Clear();

                    Console.WriteLine("   ,  /\\ ."); 
                    Console.WriteLine("  //`-||-`\\\\");
                    Console.WriteLine(" (| -=||=- |)");
                    Console.WriteLine("  \\\\,-||-.//");
                    Console.WriteLine("  ,   ||   , ");
                    Console.WriteLine("      ||");
                    Console.WriteLine("      ||");
                    Console.WriteLine("      ()");
                    Console.WriteLine();
                    Console.WriteLine("Press Enter to see the next one");
                    Console.ReadLine();
                    Console.Clear();

                    Console.WriteLine("   , , ,");
                    Console.WriteLine("   | | |");
                    Console.WriteLine(" |~~~~~~~|");
                    Console.WriteLine(" |~~~~~~~|");
                    Console.WriteLine("~~~~~~~~~~~");
                    Console.WriteLine(" ");
                    Console.WriteLine(" ");
                    Console.WriteLine(" ");
                    Console.WriteLine();
                    Console.WriteLine("Press Enter to choose another one");
                    Console.ReadLine();
                    Console.Clear();
                }
                else if (choice == "2")
                {
                    Console.WriteLine("Knock Knock");
                    Console.WriteLine();
                    Console.ReadLine();
                    Console.WriteLine("Who's There?");
                    Console.ReadLine();
                    Console.WriteLine("Armageddon");
                    Console.WriteLine();
                    Console.ReadLine();
                    Console.WriteLine("Armageddon who?");
                    Console.ReadLine();
                    Console.WriteLine("Armageddon a little bored");
                    Console.WriteLine();
                    Console.WriteLine("Press Enter to choose another one");
                    Console.ReadLine();
                    Console.Clear();
                }
                else
                {
                    Console.WriteLine("Invalid Input, please enter again");
                    Console.WriteLine();
                    Console.WriteLine("1 - Art");
                    Console.WriteLine("or");
                    Console.WriteLine("2 - Knock knock joke");
                    Console.WriteLine();
                    Console.ReadLine();
                }
            }
        }
    }
}