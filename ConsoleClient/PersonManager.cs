using ConsoleClient.DataClasses;

namespace ConsoleClient;

class PersonManager
{
    private readonly PersonRepository _repository;

    public PersonManager()
    {
        _repository = new PersonRepository();
    }

    public IQueryable<Person> GetAllAdults()
    {
        return _repository.LoadAll().Where(p => p.Age >= 18);
    }

    public IQueryable<Person> GetAllChildren()
    {
        return _repository.LoadAll().Where(p => p.Age < 18);
    }

    public Person Copy(Person person)
    {
        return person;
    }
}