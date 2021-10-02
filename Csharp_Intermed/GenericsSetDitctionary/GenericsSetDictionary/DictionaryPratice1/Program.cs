Dictionary<string, int> pessoa = new();

Console.Write("Enter file full path: ");
string path = Console.ReadLine();

try
{
    if (path is not null)
    {
        using StreamReader sr = File.OpenText(path);

        while (!sr.EndOfStream)
        {
            string[] line = sr.ReadLine().Split(',');
            string name = line[0];
            int idade = int.Parse(line[1]);
            pessoa.Add(name, idade);
        }
    }
    foreach (KeyValuePair<string, int> item in pessoa)
    {
        Console.WriteLine(item.Key + ": " + item.Value);
    }
}
catch (IOException e)
{
    Console.WriteLine(e.Message);
}