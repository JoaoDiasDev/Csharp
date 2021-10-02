﻿using System;
using System.Collections.Generic;
using System.IO;
using Set1CsharpPratice.Entities;

HashSet<LogRecord> set = new();

Console.Write("Enter file full path: ");
string path = Console.ReadLine();

try
{
    if (path is not null)
    {
        using StreamReader sr = File.OpenText(path);

        while (!sr.EndOfStream)
        {
            string[] line = sr.ReadLine().Split(' ');
            string name = line[0];
            DateTime instant = DateTime.Parse(line[1]);
            set.Add(new LogRecord { Username = name, Instant = instant });
        }
    }
    Console.WriteLine("Total users: " + set.Count);
}
catch (IOException e)
{
    Console.WriteLine(e.Message);
}
