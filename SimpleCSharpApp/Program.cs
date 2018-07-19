using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleCSharpApp
{
    class Program
    {
        static int Main(string[] args)
        {
            // Display a simple message to the user.
            Console.WriteLine("***** My First C# App *****");
            Console.WriteLine("Hello World!");
            Console.WriteLine();

            // Process any incoming tags
            //for(int i=0;i < args.Length;i++)
            //{
            //   Console.WriteLine("Arg: {0}", args[i]);
            //}

            foreach (string arg in args)
                Console.WriteLine("Arg: {0}", arg);


            string[] theArgs = Environment.GetCommandLineArgs();
            foreach (string arg in theArgs)
                Console.WriteLine("Arg: {0}", arg);


            // Wait for Enter key to be pressed before shutting down.
            Console.ReadLine();
            
            return -1;
        }
    }
}
