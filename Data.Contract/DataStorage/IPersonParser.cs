using CrossCutting.Contract.DataClasses;

namespace DavidTielke.PMA.Data.Contract.DataStorage;

public interface IPersonParser
{
    Person ParseFromCsv(string dataLine);
}