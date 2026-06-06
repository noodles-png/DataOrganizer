namespace DataOrganizer;
using System.IO; // need that for Path.

public class FileOrganizer
{
    string _path =  Directory.GetCurrentDirectory(); // edit code for path? 
    CategoryClassifier _classifier;

    public FileOrganizer(string path)
    {
        _path = path;
        _classifier = new CategoryClassifier();
    }
    
    // Preview of changes before changing
    public void Preview()
    {
        string[] files = Directory.GetFiles(_path);
        string dataName = "";
        string dataExtension = "";
        string dataCategory = "";
        Console.WriteLine("== Change the files to these Categories? ==");
        
        foreach (var file in files)
        {
            dataName =  Path.GetFileName(file);
            dataExtension = Path.GetExtension(file);
            dataCategory = _classifier.GetCategory(dataExtension);
            Console.WriteLine($"{dataName} ➡️ {dataCategory}");
        }
    }

    public void Organize()
    {
        
    }
}