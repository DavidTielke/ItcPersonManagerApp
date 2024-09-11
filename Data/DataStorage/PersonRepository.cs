using CrossCutting.Contract.DataClasses;
using DavidTielke.PMA.Data.Contract.DataStorage;
using DavidTielke.PMA.Data.Contract.FileStorage;
using DavidTielke.PMA.Data.FileStorage;

namespace DavidTielke.PMA.Data.DataStorage;

public class PersonRepository : IPersonRepository
{
    private readonly IFileReader _reader;
    private readonly IPersonParser _parser;

    public PersonRepository(IFileReader reader, IPersonParser parser)
    {
        _reader = reader;
        _parser = parser;
    }

    public IQueryable<Person> LoadAll()
    {
        var dataLines = _reader.ReadAllLines("data.csv");
        var persons = dataLines.Select(l => _parser.ParseFromCsv(l));
        return persons.AsQueryable();
    }
}