// using System;

// CLASS FOLLOW ALONG
// class Program
// {
//     static void Main(string[] args)
//     {
//         Console.WriteLine("Hello Learning02 World!");
//         Person fred = new Person("Fred", "Flinstone");
//         Person steve = new Person("Steve", "Roggers");
//         // fred.givenName = "Fred";
//         // fred.familyName = "Flinstone";  //bad way to do this
//         // instance of the person is fred! :)
       

//         fred.EasternStyleName();
//         steve.WesternStyleName();
//     }
// }


using System;
// using System.Resources;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Learning02 World!");

        Job job1 = new Job();
        job1.jobTitle = "Lifeguard";
        job1.company = "A&B Pool Services";
        job1.startYear = "2018";

        Job job2 = new Job();
        job2.jobTitle = "Chocolatier";
        job2.company = "Florence's Chocolate's";
        job2.startYear = "2022";

        Resume myResume = new Resume();
        myResume.name = "Cassidy Whitehead";

        myResume.jobs.Add(job1);
        myResume.jobs.Add(job2);

        myResume.Display();


    }
}