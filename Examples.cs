namespace Examples;

public class Hints {

    public static void dictionary()
    {
        Dictionary<string, int> dict = new Dictionary<string, int>();
        
        dict.Add("one", 1);
        dict.Add("two", 2);
        dict.Add("three", 3);
        
        // iterate over dictionary. each item in the 
        // dictionary is a key/value pair. 

        foreach(KeyValuePair<string, int> pair in dict) {
            Console.WriteLine($"{pair.Key} is {pair.Value}");
        }

    }

    public static void strings() 
    {
        // you can create a string from a char array
        string someStr = new string(new char[]{'h', 'e', 'l', 'l', 'o'});
        Console.WriteLine(someStr);
    }


}