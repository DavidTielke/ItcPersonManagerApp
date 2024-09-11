using DavidTielke.PMA.Data.Contract.DataStorage;
using DavidTielke.PMA.Data.Contract.FileStorage;
using DavidTielke.PMA.Data.DataStorage;
using DavidTielke.PMA.Data.FileStorage;
using DavidTielke.PMA.Logic.PersonManagement;
using Microsoft.Extensions.DependencyInjection;

namespace Microsoft.Extensions.DependencyInjection
{
    public static class ServiceCollectionExtensions
    {
        public static void AddApplicationMappings(this IServiceCollection collection)
        {
            collection.AddTransient<IPersonManager, PersonManager>();
            collection.AddTransient<IPersonRepository, PersonRepository>();
            collection.AddTransient<IPersonParser, PersonParser>();
            collection.AddTransient<IFileReader, FileReader>();
        }
    }
}
