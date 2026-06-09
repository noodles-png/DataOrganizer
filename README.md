# Data Organizer
## Description
This CLI program organizes unsorted files in a folder like Downloads
to move them in appropriate folders and rename the files if duplicates exist.
A sorted folder structure helps organizing (like relocating) the files.

## Requirements
- [.NET 10 SDK](https://dotnet.microsoft.com/download) (compatible with .NET 8+)

## Getting started
1. Clone the repository
```
git clone https://github.com/noodles-png/DataOrganizer.git
```
2. Open Program.cs and change directory path
```csharp 
    string directoryPath = @"C:\Your\folder\here"
```
3. Run the program:
``` 
cd DataOrganizer
dotnet run
```
4. The program will show a preview and wants to confirm these changes.
Confirm with Y/y or decline with N/n.

### Building as .exe
```
dotnet publish -c Release -r win-x64 --self-contained true -p:PublishSingleFile=true
```
The executable program will be in `bin/Release/net10.0/win-x64/publish/`.

## Configuration
If needed the categories and their individual extensions can be adjusted to own preferences.
in CategoryClassifier.cs:
```csharp
// List of the data type categories
    private Dictionary<string, string[]> _categories =  new () // string[] as array in the dict
    {
        // Adjust the extensions and folder names to preferences
        {"Pictures",  new[] { ".jpg", ".jpeg", ".png", ".gif"} }, 
        {"Documents", new[] { ".pdf", ".docx", ".odt", ".xls", ".xlsx", ".txt"} }, 
        {"Music", new[] {".wav", ".wma", ".mp3"} }, 
        {"Videos", new[] {".mp4", ".mpeg", ".avi"} },
        {"Code", new[] {".py", ".cs", ".html", ".js", ".css"} }
    };
```




