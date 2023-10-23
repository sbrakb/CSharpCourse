/* Strings */

string city = "Ankara";

foreach (var item in city)
    Console.WriteLine(item);

string city2 = "Istanbul";
string result = city + city2;

Console.WriteLine(result);
Console.WriteLine(String.Format("{0} - {1}", city, city2)); // its not take a third place in memory


/* String Methods */

string sentence = "My name is Sabır";

var result2 = sentence.Length;
Console.WriteLine(result2);        // 16

var result3 = sentence.Clone();
sentence = "Who am i";
Console.WriteLine(result3);        // My name is Sabır

bool result4 = sentence.EndsWith("ğ");
Console.WriteLine(result4);        // false

bool result5 = sentence.StartsWith("Who");
Console.WriteLine(result5);        // true

var sentence2 = "There really is no learning without doing";
// if there is more than one result, indexof returns the first index number
var result6 = sentence2.IndexOf("There");      // we can search words in a text with indexof if there is exist
Console.WriteLine(result6);                    // 0  (if "who" would not exist then indexof would return -1)

var result7 = sentence2.LastIndexOf("There");  // still 0 but start to searching from the end
Console.WriteLine(result7);

var result8 = sentence.Insert(0, "Hello, ");
Console.WriteLine(result8);     // Hello Who am i

var result9 = sentence2.Substring(3);
Console.WriteLine(result9);     // re really is no learning without doing

var result10 = sentence2.Substring(6,6);
Console.WriteLine(result10);     // really

var result11 = sentence2.Replace(" ", "-");
Console.WriteLine(result11);     // There-really-is-no-learning-without-doing

var result12 = sentence2.Remove(5);
Console.WriteLine(result12);     // There

var result13 = sentence2.Remove(5,7);
Console.WriteLine(result13);     // There

var result14 = sentence2.ToLower();
var result15 = sentence2.ToUpper();