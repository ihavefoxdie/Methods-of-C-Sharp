using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Practicing
{
    class Program
    {
        static void Main()
        {
            List<string> names = new List<string>();
            string input;

            Console.WriteLine("To stop, simply type \"Stop!\".");
            while (true)
            {
                Console.Write("What is your name?\nName: ");
                input = Console.ReadLine();
                Console.Clear();
                if (input.Contains("Stop!"))
                    break;
                names.Add(input);
            }
            Greeting(names);
        }

        static void Greeting(List<string> args)
        {
            for (int i = 0; i < args.Count; i++)
                Console.WriteLine($"Hello, { args[i]}!");
        }

    }
}