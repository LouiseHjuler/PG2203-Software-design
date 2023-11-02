using System.Xml.Linq;
using task_1_C;

var Person = new Person();
Person.FirstName = "Name";
Person.LastName = "       Nameson";

Console.WriteLine(Person.FullName);


// output console:  Name Nameson