namespace DataOrganizer;

public class CategoryClassifier
{
    // List of the data type categories
    private Dictionary<string, string[]> _categories =  new () // string[] as array in the dict
    {
        {"Pictures",  new[] { ".jpg", ".jpeg", ".png", ".gif"} },
        {"Documents", new[] { ".pdf", ".docx", ".odt", ".xls", ".txt"} }, // Add missing possible types
        {"Music", new[] {".wav", ".wma", ".mp3"} }, // Adjust the types
        {"Videos", new[] {".mp4", ".mpeg", ".avi"} },
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