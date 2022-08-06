using System;
using GenericsCSharp.Models;
using GenericsCSharp.WithoutGenerics;

namespace GenericsCSharp;

class Program
{
    static void Main(string[] args)
    {

        List<int> ages = new List<int>();



        Console.WriteLine();
        Console.Write("Press enter to shut down..");
        Console.ReadLine();
    }


    private static void DemonstrateTextFileStore()
    {
        List<Person> people = new List<Person>();
        List<LogEntry> logs = new List<LogEntry>();
        string peopleFile = @"/people.csv";
        string logFile = @"/logs.csv";

        // PopulateLists(people, logFile);
        // OriginalTextFileProcessor()

        OriginalTextFileProcessor.SavePeople(people, peopleFile);

        var newPeople = OriginalTextFileProcessor.LoadPeople(peopleFile);

        foreach (var p in newPeople)
        {
            Console.WriteLine($"{p.FirstName} {p.LastName} (IsAlive = {p.IsAlive})");
        }
    }


    private static void PopulateLists(List<Person> people, List<LogEntry> logs)
    {
        people.Add(new Person { FirstName = "John", LastName = "Yolo" });
        people.Add(new Person { FirstName = "Tom", LastName = "Oscar", IsAlive = false });
        people.Add(new Person { FirstName = "Ivan", LastName = "Polo" });

        logs.Add(new LogEntry { Message = "I blew up", ErrorCode = 9999 });
        logs.Add(new LogEntry { Message = "I'm too awesome", ErrorCode = 1337 });
        logs.Add(new LogEntry { Message = "I was tired", ErrorCode = 2222 });
    }

}