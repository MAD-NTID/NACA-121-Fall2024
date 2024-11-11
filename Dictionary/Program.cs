IDictionary<string, int> dict = new Dictionary<string, int>();

dict.Add("id", 1);

Console.WriteLine(dict.ContainKey("id"));
Console.WriteLine(dict.ContainKey("yolo"));
Console.WriteLine(dict.Get("id"));
Console.WriteLine(dict.ContainValue(1));
Console.WriteLine(dict.ContainValue(1000));
Console.WriteLine(dict.Remove("id"));

Console.WriteLine(dict.Remove("id"));


// Console.WriteLine(dict.GetIndex("foo"));
// Console.WriteLine(dict.GetIndex("foobarmeh"));
// Console.WriteLine(dict.GetIndex("fooRandom"));
// Console.WriteLine(dict.GetIndex("fooPleassseee"));
// Console.WriteLine(dict.GetIndex("tellMeWhy@"));