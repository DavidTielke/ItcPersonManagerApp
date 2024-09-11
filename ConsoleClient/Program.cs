using DavidTielke.PMA.Data.DataStorage;
using DavidTielke.PMA.Data.FileStorage;
using DavidTielke.PMA.Logic.PersonManagement;
using Microsoft.Extensions.DependencyInjection;

namespace DavidTielke.PMA.UI.ConsoleClient
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var collection = new ServiceCollection();

            collection.AddTransient<IPersonDisplayCommands, PersonDisplayCommands>();

            collection.AddApplicationMappings();
            
            var provider = collection.BuildServiceProvider();

            var commands = provider.GetRequiredService<IPersonDisplayCommands>();

            commands.DisplayAllAdults();

            commands.DisplayAllChildren();
        }
    }
}
