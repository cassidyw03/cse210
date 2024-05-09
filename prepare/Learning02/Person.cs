// using System;

// public class Job 
// {
//     public string jobTitle;
//     public string company;
//     public int startYear;

//     public void endYear;

//     public void Display()
//     {
//         Console.WriteLine($"{jobTitle} {company} {startYear} {endYear}");
//     }
// }

// CLASS FOLLOW ALONG 
// using System.Globalization;
// using System.Reflection;
// using System.Runtime.CompilerServices;

// class Person
// {
//     // default public
//     public string givenName;
//     // _ underscore says to developers to treat the variable as private
//     public string familyName;
//     // constructors instantiate
//     // constructors can never return anything
//     public Person(string givenName, string familyName) 
//     {
//         this.givenName = givenName;
//         this.familyName = familyName;
//     }

//     public void EasternStyleName()
//     {
//         Console.WriteLine($"{this.familyName}, {this.givenName}.");
//     }

//     public void WesternStyleName()
//     {
//         Console.WriteLine($"{this.givenName}, {this.familyName}.");
//     }
// }

// UML Template
// person class:    
// - = private
// + = public
// properties/attributes:   -givenName-string, -familyName-string
// methods: + eastern: (void), + western: (void)
// decision table
