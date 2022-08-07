using System;
namespace GenericsCSharp.WithGenerics;

public static class GenericTextFileProcessor
{
    public static List<T> LoadFromTextFile<T>(string filePath) where T : class, new() // < : Limiter
    {
        var lines = System.IO.File.ReadAllLines(filePath).ToList();
        List<T> output = new List<T>();
        T entry = new T();
        // Uses reflection to look at run-time properties
        var cols = entry.GetType().GetProperties();

        if (lines.Count < 2)
        {
            throw new IndexOutOfRangeException("The file was either empty of missing.");
        }

        var headers = lines[0].Split(',');

        lines.RemoveAt(0);

        foreach (var row in lines)
        {

            entry = new T();

            var vals = row.Split(',');

            for (var i = 0; i < headers.Length; i++)
            {
                foreach (var col in cols)
                {
                    if (col.Name == headers[i])
                    {
                        col.SetValue(entry, Convert.ChangeType(vals[i], col.PropertyType));
                    }
                }
            }

            output.Add(entry);
        }

        return output;

    }
}

