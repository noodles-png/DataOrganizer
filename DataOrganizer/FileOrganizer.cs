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

    // Collects the file informations
    private Dictionary<string, string> GetFileCategories()
    {
        var result = new Dictionary<string, string>();
        string[] files = Directory.GetFiles(_path);

        foreach (var file in files)
        {
            string fileCategory = _classifier.GetCategory(Path.GetExtension(file));
            result[file]= fileCategory;
        }
        return result;
    }
    
    // Preview of changes before changing
    public void Preview()
    {
        Console.WriteLine("== Change the files to these Categories? ==");
        
        foreach (var entry in GetFileCategories())
        {
            Console.WriteLine($"{Path.GetFileName(entry.Key)} -> {entry.Value}");
        }
    }
    
    // Moves files and renames duplicates
    public void Organize()
    {
        foreach (var entry in GetFileCategories())
        {
            string targetDir = Path.Combine(_path, entry.Value);
            string targetFile = Path.Combine(targetDir, Path.GetFileName(entry.Key));
            
            // If duplicates in the directory exist: add a counter (n) to the name e.g. "File(1)"
            if (File.Exists(targetFile))
            {
                string name = Path.GetFileNameWithoutExtension(entry.Key);
                string ext = Path.GetExtension(entry.Key);
                int count = 1;
                while (File.Exists(targetFile))
                {
                    targetFile = Path.Combine(targetDir, $"{name} ({count}){ext}");
                    count++;
                }
            }
            
            Console.WriteLine($"Moving: {entry.Key} → {targetFile}");

            Directory.CreateDirectory(targetDir);
            File.Move(entry.Key, targetFile, true);
        }
    }
}
