### Hi! This is a set short practicing tasks 


#### Task 01
<p>
Using `Visual Studio`, create a `Console Application` project.
Create a `class Rectangle`.
In the class body, create two fields describing the lengths of the sides `double side1`, `side2`.
Create a custom Rectangle constructor which takes arguments `(double side1, double side2)` which initializes fields `side1` and `side2` with argument values.
Create two methods that calculate the area of the rectangle - `double AreaCalculator()` and the perimeter of the rectangle - `double PerimeterCalculator()`.
Create two properties, `double Area` and `double Perimeter`, with one `get` access method.
Write a program that takes the length of two sides of the rectangle from the user and displays the perimeter and area. The program must ask user to enter the data, until the input is correct. 
</p>

#### Solution (main tricky points)
1. Property Area is `public double Area { get {return this.AreaCalculator();} }`. Returns results of `AreaCalculator` method called on `this` object of a class.
2. In the program class a method `double GetSide()` was created which tries to parse input into `double s`.
3. `While` loop uses two methods `GetSide()` until `rec.Area > 0 && rec.Perimeter > 0` is true. It means that inputs were succesfully parsed into `double`, and satisfactory results were calculated. Additional `bool Test` is used, and it gets value `True`, when the input is correct, and then the loop breaks.

<div>
#### Task 10
<p>
Using Visual Studio, create a Console Application project.
Create a collection `MyDictionary <TKey, TValue>`. Implement the possibility of using its instance as if it were an instance of the `Dictionary <TKey, TValue> class`. The minimum interface required for interacting with an instance should include a method for adding an element, an indexer to get the value of an element at a specified index, and a read-only property to get the total number of elements. Implement the ability to iterate through the elements of a collection in a `foreach` loop.
</p>

#### Solution

1. Create collection `MyDictionary <Tkey, Tvalue>` that will implement interfaces `IEnumerable<object>`, `IEnumerator<object>`.
1.2. `MyDictionary <Tkey, Tvalue>` immitates `Dictionary <TKey, TValue> class` with the help of two arrays `Tkey[] tKey` and `Tvalue[] tValue`. Both are set to readonly.
1.3. In the collection type:
- `MyDictionary <Tkey, Tvalue>` uses user`s constructor `MyDictionary(int n)` with initiates length of both arrays `tKey` and `tValue`. It also initiates `int legth`, that will be used later;
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
</div>

#### Task 11
<p>
Using Visual Studio, create a Console Application project.
Create a structure named `Price`, containing the following fields:
• `Product Name`;
• the `name of the store` where the product is being sold;
• the price.
Then write a program that performs the following actions:
• input from the keyboard data into an array consisting of two elements of type `Price` (entries must be arranged in alphabetical order by store name);
• displaying information about products sold in a store which number (1||2) is entered from the keyboard (if there is no such store, display an exception).
</p>

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


<p>
#### Task 12

Create the `class House` with two fields and properties that describe `city` and `street` where the house stands. `Street` must be represented as a `class` that implements interface for clonning. 
Create two methods `Clone()` and `DeepClone()`, which perform shallow and deep copying, respectively. Implement a simple way to check.
</p>

#### Solution

1. The `class House` have two private fields: `string city` and `Street street`, and properties: `string City` and `Street Street` accordingly.
- constructor `public House(args)` initiates fields with values;
- `public House Clone()` returns `this`, as a refernce to the instance;
- `public House DeepClone()` returns `new House` where it copies the fields of the original instance (`this.street.Clone()`, `this.City`), not the references.
2. The `class Street : IClonable` implements the interface to be cloned;
- field `string str` stores the name of the street. Property `Str` only returns its value;
- `public Street(args)` initiates field `str`;
- `public object Clone()` implements interface `Iclonable` and the method returns `new Street(this.str)` that copies the fields of the source instance.
3. `class Program` creates a new instance of `House` with parameters `new Street("Rambergveien")` and `"Toensberg"`. `House clone = house.DeepClone()` is made to clone the instance. `Console.WriteLine` of both properties shows the result.


<p>
#### Task 13

Create a class that will contain information about the date (day, month, year). Using the operator overload determine the operation of the difference between two dates (the result is the number of days between dates), and the operation of increasing the date by a certain number of days.
</p>

#### Solution
1. Create a `class MyDate` which cointains readonly field `DateTime date` and static overloaded methods.
- `public MyDate(args)` initiates field date;
- `public static MyDate operator - ()` accepts two objects of `MyDate` type. A new `TimeSpan` object equals the substraction between two entered dates. Then a `new DateTime` object is the first date with an added timespan. Timespan can have negative value. Adjusted first `DateTime` argument is returned;
- `public static MyDate operator + ()` is quite the same, but adds `-timeSpan`, which results in positive increasing;
- `public override string ToString()` returns literal `Date:` and `date` field.
- `public static MyDate Sub(args)` returns overriden d1 - d2;
- `public static MyDate Add(args)` returns overriden d1 + d2.
2. `class Program` creates a new instance of current date `DateTime.Now` and instance of second date. `MyDate.Sub(date1, date2).ToString()` returns difference in days.


<p>
#### Task 14

Using Visual Studio, create a project using the Console Application template.
Imagine that you are writing an application for a Bus Station and you need to create a simple `collection of cars` with the following data: `car make`, `model`, `year` of production, and `color`. As well as the `second collection` with a `car model`, the `name of the buyer` and his `phone number`. Using a simple LINQ query, display `information` about the `buyer, their car/cars, and the `full description` of the model they purchased.
</p>

#### Solution
1. Create `class Car` with readonly fields `carMake`, `model`, `year`, `color`, properties and user`s constructor that initiates all fields.
2. Create `class Customer` with readonly fields `model`, `name`, `cellPhone`, properties and user`s constructor that initiates all fields.
3. In the program class create two lists for `Cars` and `Customers` and initiate them with 4 new cars and 3 new customers. Then, create a `Linq` query that selects all values with `join ...  on car.Model equals cust.Model`. Results are passed as an `anonyme type` with all required properties from both lists. Write on the console the inhold in the query.


<p>
#### Task 15

Create a collection that stores the names of 12 months, the order number and the number of days in the corresponding month. Implement the ability to select months as per serial number as well as the number of days in a month. The result may not be only one month.
</p>

#### Solution
1. Create `class Month` with readonly fields `order`, `name`, `days` and corresponding properties.
- `public Month(int order, int name)` constructor takes the order number and number of the month. Month`s `name` is taken from `CultureInfo.CurrentCulture.DateTimeFormat.GetMonthName(name)` property, and `number` of days is from `DateTime.DaysInMonth(DateTime.Now.Year, name)`.
- `public override string ToString()` returns a full information about the month.
- `public bool FindMonth(int days)` returns true if passed number of days ie equal to the number of days in the instance of the class.
2. Create `class Calendar: IEnumerable, IEnumerator` which contains an array of `Month` instances.
- `public Calendar()` creates an array (size 12) an authomatically fills it with instances with uatomated values.
- `IEnumerable` implements method that upcastes `Calendar` to the `IEnumerator` type.
- `IEnumerator` members are implemented: position, object Current, bool MoveNext(), void Reset(), string this[int index].
- method `void FindMonthesByDays(int days)` writes on the console all the `Month` instances on which `FindMonth` method returns `true`. In case of problem it shows `"The month does not exist!"`.
3. Program file creates an arrays and asks for user`s input. Inputs are within `try/catch` blocks.


<p>
#### Task 16

Create an `abstract class Citizen`. Create `classes Student`, `Pensioner`, `Worker` inherited from `Citizen`. Create a non-parameterized collection with the following functions.
1. Add:
  - you can add only `Citizen`.
  - the item is added to the end of the collection. If item is `Pensioner`, it must be added at the beginning and after the previously standing pensioners. The number in the queue must be returned.
  - adding the same person (check by passport number; you must override the `Equals` method) the item is not added, it the message is showed.

2. Remove:
  - Deleting must start from the beginning of the collection.
  - It is possible to delete with the transfer of a copy of the Citizen.

3. The `Contains` method must return `true/false` when an item is `in/out` of the collection, and its number in the queue.

4. The `ReturnLast` method returns the last person in the queue and its number in the queue.

5. The `Clear` method clears the collection.

6. You can work with the collection with the `foreach` operator.
</p>

#### Solution
1. 
</p>