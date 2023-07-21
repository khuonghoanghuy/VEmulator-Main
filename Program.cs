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
            bool atQEMU = false;
            
            switch (input)
            {
                case "help":
                    Console.Clear();
                    Console.WriteLine("- HELP -");
                    Console.WriteLine("Command List: \n- `start` start run qemu with command\n- `exit` exit app");
                    return;

                case "start":
                    Console.Clear();
                    atQEMU = true;
                    if (atQEMU)
                    {
                        Console.WriteLine("Set your RAM");
                        string ram = Console.ReadLine();
                        Console.Write("Your ram is: " + ram);

                        Console.WriteLine("Set your cpu");
                        string cpu = Console.ReadLine();
                        Console.Write("Your cpu is: " + cpu);

                        Console.WriteLine("Path your Hard disk");
                        string hd = Console.ReadLine();
                        Console.WriteLine("Your hard disk from: " + hd);

                        string code = "-m " + ram + " -hda " + hd + " -cpu " + cpu;

                        System.Diagnostics.Process.Start("qemu-system-x86_64.exe", code);
                    }
                    break;

                case "exit":
                    System.Environment.Exit(1);
                    break;
            }
        }
    }
}