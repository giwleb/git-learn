Console.WriteLine("Start");

string x = null;
//var uniqueIds = new List<string> {"1", "2", "3", "4"}; // good
//var uniqueIds = new List<string> {x, x, x}; // good
//var uniqueIds = new List<string> {"", "2", "3", "4"}; //bad
//var uniqueIds = new List<string> {x, "2", "3", "4"}; //bad
//var uniqueIds = new List<string> {"2", "4", "2", x}; //bad
//var uniqueIds = new List<string> {"1", "1", "3", "4"}; //bad

//var uniqueIds = new List<string> {"1", "2", "3", "4"}; // good
var uniqueIds = new List<string> {"4", "2", "1", "3"}; // good
            int hash = 0;

            foreach (var element in uniqueIds)
            {
                hash = unchecked(hash + EqualityComparer<string>.Default.GetHashCode(element));
            }
            Console.WriteLine($"{hash}");
var uniqueIds2 = new List<string> {"1", "2", "3", "4"}; // good
            hash = 0;

            foreach (var element in uniqueIds2)
            {
                hash = unchecked(hash + EqualityComparer<string>.Default.GetHashCode(element));
            }
Console.WriteLine($"{hash}");            
var uniqueIds3 = new List<string> {"4", "3", "2", "1"}; // good
            hash = 0;

            foreach (var element in uniqueIds3)
            {
                hash = unchecked(hash + EqualityComparer<string>.Default.GetHashCode(element));
            }
Console.WriteLine($"{hash}");              
var uniqueIds4 = new List<string> {"6", "3", "2", "1"}; // good
            hash = 0;

            foreach (var element in uniqueIds4)
            {
                hash = unchecked(hash + EqualityComparer<string>.Default.GetHashCode(element));
            }            
// bool y = uniqueIds.All(s => string.IsNullOrWhiteSpace(s));

// if (!uniqueIds.All(s => string.IsNullOrWhiteSpace(s)))
// {
//     if (uniqueIds.Any(s => string.IsNullOrWhiteSpace(s)))
//     {
//         throw new ArgumentOutOfRangeException($"Some uniqueIds passed had values, but not all.");
//     }
//     else {
//         var diffChecker = new HashSet<string>();

      //  foreach (var t in uniqueIds)
      //  {
      //      if (diffChecker.Add(t))
      //      {
      //          continue;
      //      }

      //      throw new ArgumentOutOfRangeException("UniqueId for detail items must be unique across the entire transaction");
      //  }
    //  if (!uniqueIds.All(a => diffChecker.Add(a)))
    //   throw new ArgumentOutOfRangeException("UniqueId for detail items must be unique across the entire transaction");
    // }    
//}

Console.WriteLine($"{hash}");
//-1379183755

