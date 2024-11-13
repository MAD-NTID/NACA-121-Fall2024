IDictionary<string, int> dict = new Dictionary<string, int>();

for(int i = 0; i < 10000; i++) {
    Console.WriteLine($"Adding the element:{i+1} to the dictionary");
    string key = (i+1).ToString();
    dict.Add(key,i+1);

}

// dict.Add("id", 1);

// Console.WriteLine(dict.ContainKey("id"));
// Console.WriteLine(dict.ContainKey("yolo"));
// Console.WriteLine(dict.Get("id"));
// Console.WriteLine(dict.ContainValue(1));
// Console.WriteLine(dict.ContainValue(1000));
// Console.WriteLine(dict.Remove("id"));

// Console.WriteLine(dict.Remove("id"));


// Console.WriteLine(dict.GetIndex("foo"));
// Console.WriteLine(dict.GetIndex("foobarmeh"));
// Console.WriteLine(dict.GetIndex("fooRandom"));
// Console.WriteLine(dict.GetIndex("fooPleassseee"));
// Console.WriteLine(dict.GetIndex("tellMeWhy@"));