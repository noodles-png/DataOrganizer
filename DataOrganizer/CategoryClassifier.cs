namespace DataOrganizer;

public class CategoryClassifier
{
    // List of the data type categories
    private Dictionary<string, string[]> _categories =  new () // string[] as array in the dict
    {
        {"Pictures",  new[] { ".jpg", ".jpeg", ".png", ".gif"} }, 
        {"Documents", new[] { ".pdf", ".docx", ".odt", ".xls", ".xlsx", ".txt"} }, // ToDO Add missing possible types! html and xml?
        {"Music", new[] {".wav", ".wma", ".mp3"} }, // ToDo Adjust the types!
        {"Videos", new[] {".mp4", ".mpeg", ".avi"} },
        {"Code", new[] {".py", ".cs", ".html", ".js", ".css"} }
    };
    // Reads filename extension and returns category
    public string GetCategory(string extension)
    {
        extension = extension.ToLower(); 
        
        foreach (var entry in _categories)
        {

            if (entry.Value.Contains(extension))
            {
                return entry.Key;
            }
        }

        return "Misc.";
    }
}