Dictionary<string, string> cookies = new();

cookies["user"] = "maria";
cookies["email"] = "maria@gmail.com";
cookies["phone"] = "99712234";
cookies["phone"] = "83737388";

cookies.Remove("email");

try
{
    Console.WriteLine(cookies["email"]);
}
catch (Exception)
{

    throw;
}

Console.WriteLine("Size: " + cookies.Count);

Console.WriteLine("ALL COOKIES:");

foreach (KeyValuePair<string,string> item in cookies)
{
    Console.WriteLine(item.Key + ": " + item.Value);
}