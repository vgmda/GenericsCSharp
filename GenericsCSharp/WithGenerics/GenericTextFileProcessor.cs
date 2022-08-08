using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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


    public static void SaveToTextFile<T>(List<T> data, string filePath) where T : class
    {
        List<string> lines = new List<string>();
        StringBuilder line = new StringBuilder();

        if (data == null || data.Count == 0)
        {
            throw new ArgumentNullException("data", "You must populate the data parameter with at least one value.");
        }

        var cols = data[0].GetType().GetProperties();

        foreach (var col in cols)
        {
            line.Append(col.Name);
            line.Append(",");
        }

        lines.Add(line.ToString().Substring(0, line.Length - 1));

        foreach (var row in data)
        {
            line = new StringBuilder();

            foreach (var col in cols)
            {
                line.Append(col.GetValue(row));
                line.Append(',');
            }

            lines.Add(line.ToString().Substring(0, line.Length - 1));
        }

        System.IO.File.WriteAllLines(filePath, lines);
    }

}

