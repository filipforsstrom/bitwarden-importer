using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using CsvHelper;

if (args.Length != 1)
{
    Console.WriteLine("Usage: <inputFile>");
    return;
}

string inputFile = args[0];

// Read the CSV file
using var reader = new StreamReader(inputFile);
using var csv = new CsvReader(reader, CultureInfo.InvariantCulture);
var inputRecords = csv.GetRecords<Input>();

// Create new records without the grouping column
var outputRecords = new List<Output>();
foreach (var record in inputRecords)
{
    outputRecords.Add(new Output
    {
        url = record.url,
        username = record.username,
        password = record.password,
        totp = record.totp,
        extra = record.extra,
        name = record.name,
        fav = record.fav
    });
}

// Write the updated records to a new CSV file
using var writer = new StreamWriter("output.csv");
using var csvWriter = new CsvWriter(writer, CultureInfo.InvariantCulture);
csvWriter.WriteRecords(outputRecords);

Console.WriteLine("Successfully removed 'grouping' column from the CSV file.");


public class Input
{
    public string url { get; set; }
    public string username { get; set; }
    public string password { get; set; }
    public string totp { get; set; }
    public string extra { get; set; }
    public string name { get; set; }
    public string grouping { get; set; }
    public string fav { get; set; }
}

public class Output
{
    public string url { get; set; }
    public string username { get; set; }
    public string password { get; set; }
    public string totp { get; set; }
    public string extra { get; set; }
    public string name { get; set; }
    public string fav { get; set; }
}