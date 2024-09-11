using DavidTielke.PMA.Data.Contract.FileStorage;

namespace DavidTielke.PMA.Data.FileStorage;
public class FileReader : IFileReader
{
    public IEnumerable<string> ReadAllLines(string path)
    {
        return File.ReadAllLines(path);
    }
}