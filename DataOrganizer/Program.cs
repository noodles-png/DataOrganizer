using DataOrganizer;

var mapper = new CategoryClassifier();
Console.WriteLine(mapper.GetCategory(".jpg"));
Console.WriteLine(mapper.GetCategory(".pdf"));
Console.WriteLine(mapper.GetCategory(".xyz"));

var organizer = new FileOrganizer(@"C:\Users\PatrickCarillo\RiderProjects\DataOrganizer\.idea\TestOrdner");
organizer.Preview();