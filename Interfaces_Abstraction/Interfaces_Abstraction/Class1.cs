
public class DictionaryExample
{
    class RudimentaryMultiValuedDictionary<TKey, TValue> : IEnumerable<KeyValuePair<TKey, List<TValue>>>
    {
        private Dictionary<TKey, List<TValue>> internalDictionary = new Dictionary<TKey, List<TValue>>();

        public IEnumerator<KeyValuePair<TKey, List<TValue>>> GetEnumerator() => internalDictionary.GetEnumerator();

        System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator() => internalDictionary.GetEnumerator();

        public List<TValue> this[TKey key]
        {
            get => internalDictionary[key];
            set => Add(key, value);
        }

        public void Add(TKey key, params TValue[] values) => Add(key, (IEnumerable<TValue>)values);

        public void Add(TKey key, IEnumerable<TValue> values)
        {
            if (!internalDictionary.TryGetValue(key, out List<TValue> storedValues))
                internalDictionary.Add(key, storedValues = new List<TValue>());
            
            storedValues.AddRange(values);
        }
    }

    //public static void Main()
    //{
    //    RudimentaryMultiValuedDictionary<string, string> rudimentaryMultiValuedDictionary1
    //        = new RudimentaryMultiValuedDictionary<string, string>()
    //        {
    //            {"Group1", "Bob", "John", "Mary" },
    //            {"Group2", "Eric", "Emily", "Debbie", "Jesse" }
    //        };
    //    RudimentaryMultiValuedDictionary<string, string> rudimentaryMultiValuedDictionary2
    //        = new RudimentaryMultiValuedDictionary<string, string>()
    //        {
    //            ["Group1"] = new List<string>() { "Bob", "John", "Mary" },
    //            ["Group2"] = new List<string>() { "Eric", "Emily", "Debbie", "Jesse" }
    //        };
    //    RudimentaryMultiValuedDictionary<string, string> rudimentaryMultiValuedDictionary3
    //        = new RudimentaryMultiValuedDictionary<string, string>()
    //        {
    //            {"Group1", new string []{ "Bob", "John", "Mary" } },
    //            {"Group2", new string []{ "Eric", "Emily", "Debbie", "Jesse" } }
    //        };

    //    Console.WriteLine("Using first multi-valued dictionary created with a collection initializer:");

    //    foreach (KeyValuePair<string, List<string>> group in rudimentaryMultiValuedDictionary1)
    //    {
    //        Console.WriteLine($"\r\nMembers of group {group.Key}: ");

    //        foreach (string member in group.Value)
    //        {
    //            Console.WriteLine(member);
    //        }
    //    }

    //    Console.WriteLine("\r\nUsing second multi-valued dictionary created with a collection initializer using indexing:");

    //    foreach (KeyValuePair<string, List<string>> group in rudimentaryMultiValuedDictionary2)
    //    {
    //        Console.WriteLine($"\r\nMembers of group {group.Key}: ");

    //        foreach (string member in group.Value)
    //        {
    //            Console.WriteLine(member);
    //        }
    //    }
    //    Console.WriteLine("\r\nUsing third multi-valued dictionary created with a collection initializer using indexing:");

    //    foreach (KeyValuePair<string, List<string>> group in rudimentaryMultiValuedDictionary3)
    //    {
    //        Console.WriteLine($"\r\nMembers of group {group.Key}: ");

    //        foreach (string member in group.Value)
    //        {
    //            Console.WriteLine(member);
    //        }
    //    }
    //}

    /*
     * Prints:

        Using first multi-valued dictionary created with a collection initializer:

        Members of group Group1:
        Bob
        John
        Mary

        Members of group Group2:
        Eric
        Emily
        Debbie
        Jesse

        Using second multi-valued dictionary created with a collection initializer using indexing:

        Members of group Group1:
        Bob
        John
        Mary

        Members of group Group2:
        Eric
        Emily
        Debbie
        Jesse

        Using third multi-valued dictionary created with a collection initializer using indexing:

        Members of group Group1:
        Bob
        John
        Mary

        Members of group Group2:
        Eric
        Emily
        Debbie
        Jesse
     */
}