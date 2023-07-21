using System;

namespace VEmualtor
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Thank for Download VEmualtor!!");
            Console.WriteLine("Please using command like 'help' for more info about this app");

            string input = Console.ReadLine();
            
            switch (input)
            {
                case "help":
                    Console.Clear();
                    Console.WriteLine("- HELP -");
                    Console.WriteLine("Command List: \n- `start` start run qemu with command\n- `exit` exit app");
                    return;

                case "exit":
                    System.Environment.Exit(1);
                    break;
            }
        }
    }
}