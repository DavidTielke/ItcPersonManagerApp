using System.Reflection.PortableExecutable;
using ConsoleClient.DataClasses;

namespace ConsoleClient
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var utils = new PersonUtils();

            var commands = new PersonDisplayCommands();

            commands.DisplayAllAdults();

            commands.DisplayAllChildren();
        }
    }
}
