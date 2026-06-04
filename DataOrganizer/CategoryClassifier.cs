namespace DataOrganizer;

public class CategoryClassifier
{
    private Dictionary<string, string> _categories =  new ()
    {
        {"Pictures",  new[] { ".jpg", ".jpeg", ".png", ".gif",}},
        {"Documents", new[] { ".pdf", ".docx", ".odt", ".xls", ".txt"}},
        {"Music", new[]}
        {"Videos", new[] }
    }
    
}