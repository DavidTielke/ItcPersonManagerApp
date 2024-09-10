using DavidTielke.PMA.CrossCutting.DataClasses;
using DavidTielke.PMA.Data.FileStoring;

namespace DavidTielke.PMA.Data.DataStoring;

public class PersonRepository
{
    private readonly FileReader _reader;
    private readonly PersonParser _parser;

    public PersonRepository()
    {
        _reader = new FileReader();
        _parser = new PersonParser();
    }
    public IQueryable<Person> LoadAll()
    {
        var dataLines = _reader.ReadAllLines("data.csv");
        var persons = dataLines.Select(l => _parser.ParseFromCsv(l));
        return persons.AsQueryable();
    }
}