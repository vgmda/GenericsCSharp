using System;
using GenericsCSharp.Models;
using GenericsCSharp.WithGenerics;
using GenericsCSharp.WithoutGenerics;

namespace GenericsCSharp;

class Program
{
    static void Main(string[] args)
    {

        // List<int> ages = new List<int>();

        Console.ReadLine();

        DemonstrateTextFileStore();

        Console.WriteLine();
        Console.Write("Press enter to shut down...");
        Console.ReadLine();
    }


    private static void DemonstrateTextFileStore()
    {
        List<Person> people = new List<Person>();
        List<LogEntry> logs = new List<LogEntry>();
        string peopleFile = @"./people.csv";
        string logFile = @"./logs.csv";

        PopulateLists(people, logs);

        GenericTextFileProcessor.SaveToTextFile<Person>(people, peopleFile);
        GenericTextFileProcessor.SaveToTextFile<LogEntry>(logs, logFile);

        // var = List<Person>
        var newPeople = GenericTextFileProcessor.LoadFromTextFile<Person>(peopleFile);

        foreach (var p in newPeople)
        {
            Console.WriteLine($"{p.FirstName} {p.LastName} (IsAlive = {p.IsAlive})");
        }

        var newLogs = GenericTextFileProcessor.LoadFromTextFile<LogEntry>(logFile);

        foreach (var log in newLogs)
        {
            Console.WriteLine($"{log.ErrorCode}: {log.Message} at {log.TimeOfEvent.ToShortTimeString()}");
        }


        //OriginalTextFileProcessor.SaveLogs(logs, logFile);

        //var newLogs = OriginalTextFileProcessor.LoadLogs(logFile);

        //foreach (var log in newLogs)
        //{
        //    Console.WriteLine($"{log.ErrorCode}: {log.Message} at {log.TimeOfEvent.ToShortTimeString()}");
        //}

        // OriginalTextFileProcessor()

        //OriginalTextFileProcessor.SavePeople(people, peopleFile);

        //// var = List<Person>
        //var newPeople = OriginalTextFileProcessor.LoadPeople(peopleFile);

        //foreach (var p in newPeople)
        //{
        //    Console.WriteLine($"{p.FirstName} {p.LastName} (IsAlive = {p.IsAlive})");
        //}
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