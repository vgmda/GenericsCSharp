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

        PopulateLists(people, logFile);
    }


}