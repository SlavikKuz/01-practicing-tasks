### Hi! This is a set short practicing tasks 

#### Task 10
Using Visual Studio, create a Console Application project.
Create a collection `MyDictionary <TKey, TValue>`. Implement the possibility of using its instance as if it were an instance of the `Dictionary <TKey, TValue> class`. The minimum interface required for interacting with an instance should include a method for adding an element, an indexer to get the value of an element at a specified index, and a read-only property to get the total number of elements. Implement the ability to iterate through the elements of a collection in a `foreach` loop.



#### Solution

1. Create collection `MyDictionary <Tkey, Tvalue>` that will implement interfaces `IEnumerable<object>`, `IEnumerator<object>`.
1.2. `MyDictionary <Tkey, Tvalue>` immitates `Dictionary <TKey, TValue> class` with the help of two arrays `Tkey[] tKey` and `Tvalue[] tValue`. Both are set to readonly.
1.3. In the collection type:
- `MyDictionary <Tkey, Tvalue>` uses user's constructor `MyDictionary(int n)` with initiates length of both arrays `tKey` and `tValue`. It also initiates `int legth`, that will be used later;
- `public void Add(int i, Tkey a, Tvalue b)` adds values to both arrays, at position `i`;
- `public string this[int index]` checks input to be within boundaries of the arrays and return values cast to string, otherwise notifies about wrong input.
1.4. `IEnumerable<object>` implementation:
- `IEnumerator<object> IEnumerable<object>.GetEnumerator()` upcasts class to IEnumerator<object>;
- `public IEnumerator GetEnumerator()` upcasts to IEnumerator;
- `public void Dispose()` uses method `Reset()` which sets the position to -1, so it can be used again from the begining. Foreach does not resets numerator, but it calls `Dispose()` method.
1.5. `IEnumerator<object>` implementation:
- `public bool MoveNext()` if position is lower the array.Lenght-1, then shifts position to +1 and returns true;
- `public void Reset()` sets the position to -1;
- public property `object Current` returns current values at `[position]` from both arrays;
- private property `object IEnumerator.Current` also returns current values at `[position]` from both arrays.  
2. Create `class Program` which executes the code.
2.1. Create instance of `MyDictionary<string, string>(3)` and fill in values using method `Add()` on the instance.
2.2. Using `foreach` loop show all values in the Console.
2.3. Write in the Console value by position, and total length.

#### Task 11
Using Visual Studio, create a Console Application project.
Create a structure named `Price`, containing the following fields:
• `Product Name`;
• the `name of the store` where the product is being sold;
• the price.
Then write a program that performs the following actions:
• input from the keyboard data into an array consisting of two elements of type `Price` (entries must be arranged in alphabetical order by store name);
• displaying information about products sold in a store which number (1||2) is entered from the keyboard (if there is no such store, display an exception).

#### Solution

1. Create `struct Prices` that has private fields `string productName`, `string storeName`, and nullable `double? price`. Accordingly public access properties with only `get` accessor: `ProductName`, `StoreName`, and `Price`. The struct has constructor that receives values and intiates fields.
2. Create `class Stores` that includes: array of structs `Prices[] stores`, constructor, method `Show()`, and indexer.
- `Prices[] stores` is declared in the body of the class and will be initiated by constructor;
- `public Stores()` creates an array of size [2], then asks the user to type in values that are assigned to the structs in the array. Entered price value is within try/catch block which ensures the `Convert.ToDouble()` function;
- `string Show(Prices a)` returns values if the struck as a string;
- `public string this[int index]` tries if inxed is within array.Length and catche exception. Indexer returns `Show(stores[index])` which represent the requested line.
3. Create `class Program` which executes the code.
- creates new class of two stores inside;
- print out data from the array;
- asks user input (1||2), then try/catch `Convert.ToInt32` function to protect input;
- shows requested store.



