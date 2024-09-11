namespace DavidTielke.PMA.Data.Contract.FileStorage;

public interface IFileReader
{
    IEnumerable<string> ReadAllLines(string path);
}