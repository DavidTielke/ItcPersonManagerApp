using CrossCutting.Contract.DataClasses;

namespace DavidTielke.PMA.Data.Contract.DataStorage;

public interface IPersonRepository
{
    IQueryable<Person> LoadAll();
}