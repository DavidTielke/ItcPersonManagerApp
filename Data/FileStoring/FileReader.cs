namespace DavidTielke.PMA.Data.FileStoring;

class FileReader
{
    public IEnumerable<string> ReadAllLines(string path)
    {
        return File.ReadAllLines(path);
    }
}