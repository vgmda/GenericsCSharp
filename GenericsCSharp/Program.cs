using System;
using GenericsCSharp.Models;

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
        string peopleFile = @"./people.csv";
        string logFile = @"./logs.csv";

        // PopulateLists(people, logFile);

        OriginalTextFileProcessor.SavePeople(people, peopleFile);

        var newPeople = OriginalTextFileProcessor.LoadPeople(peopleFile);

        foreach (var p in newPeople)
        {
            Console.WriteLine($"{p.FirstName} {p.LastName} (IsAlive = {p.IsAlive})");
        }
    }


    private static void PopulateLists(List<Person> people, List<LogEntry> logs)
    {
        people.Add(new Person { FirstName = "Tim", LastName = "Corey" });
        people.Add(new Person { FirstName = "Sue", LastName = "Storm", IsAlive = false });
        people.Add(new Person { FirstName = "Greg", LastName = "Olsen" });

        logs.Add(new LogEntry { Message = "I blew up", ErrorCode = 9999 });
        logs.Add(new LogEntry { Message = "I'm too awesome", ErrorCode = 1337 });
        logs.Add(new LogEntry { Message = "I was tired", ErrorCode = 2222 });
    }

}