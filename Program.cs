
//////Add to list
//var names = new List<string>()
//{
//    "Ousman",
//    "Alieu"
//};

//names.Add("Gibril");

//foreach (var name in names)
//    Console.WriteLine(name);

//////Add Range
//string[] newNames = { "Tommy", "Kebba", "Ousman", "Hoja", "Alieu" };
//names.AddRange(newNames);

//////insert
//names.Insert(2, "Oley");

//////Sort List
//names.Sort();
//names.Reverse();



//////Remove
//names.Remove("Ousman");
//names.RemoveAt(4);
//names.RemoveRange(1, 4);

////Filter with LINQ
//names = names.Where(name => name != "Oley").ToList();

////view data in list
foreach (var name in names)
 Console.WriteLine(name);

//INDEX OF
var index = names.IndexOf("Oley");
Console.WriteLine(index);


//SPLIT
//var fullName = "Ousman Jasseh";
//var names = fullName.Split(" ");

//foreach (var name in names)
//Console.WriteLine(name);
