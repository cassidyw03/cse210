using System;
// using System.Runtime.InteropServices.Marshalling;
using Internal;
// using Internal;

static void Main();
{
    Console.WriteLine("Counting from 1 to 5:");
    for (int i = 1; <= 5; i++)
    // declare iterator, only iterators in a for loop for now
    // declaring "index" usually start at 0
    // inner part is actual condition of for loop ie: (<= 5)
    // += is the same thing as ++, adds one, iterator, i = i+1, i++, i += 1
    {
        Console.WriteLine(i);
    }
}

int counter = 1;
while (counter <= 3) {
    Console.WriteLine("Loop Iteration: " + counter);
    counter++;
}
// look up do-while loops

// Lists!
List<string>fruits = new List<string>();
// have to specify new list class of strings 

fruits.Add("Apple");
fruits.Add("Banana");
fruits.Add("Mango"); 
// add is like append
// remove is like pop
// removeAt(from index)
fruits.Remove("Apple");
// have to declare data type
// prepend- put something at te front of a list 


// function in c#
static int AddNumbers(int a, int b)
{
    int result = a + b;
    return result;
}
// static- doesn't belong to anyone
// must indicate what data type function will return
// all classes should start with an uppercase
