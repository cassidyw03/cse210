// using System;
// using System.IO;
// namespace JournalApplication {
// public class Journal {
//     // save the Journal
//     // WRITE DISPLAY PARSE
//     private string fileName = "myFile.txt";
//     private List<Entry> entries = new List<Entry>();

//     public Journal() {
//         if (File.Exists(fileName));
//         string[] lines = File.ReadAllLines(fileName);
//         foreach (string ln in lines)
//         {
//             Console.WriteLine(ln);
//             string[] splt = ln.Split( new string[] {"%%"}, StringSpiltOptions.None);
//             string dateString = splt[0];
//             string prompt = splt[1];
//             string msg = splt[2];
//             Entry entry = new Entry( dateString, prompt);
//             entry.SetMessage(msg);
//             addEntry(entry);
//         }
    

//     }

//     public void addEntry(Entry entry)
//     {
//         entries.Add(entry);
//     }

//     public Entry getEntry (string dateString)
//     {
//         Entry entry = new Entry("", "");
//         entries.ForEach(e =>
//         {
//             string entryDateString = e.GetDateString();
//             if (entryDateString == dateString)
//             {
//                 entry = e;
//             }
//         });
//         return entry;
//     }

//     public void DisplayJournal()
//     {
//         entries.ForEach(e =>
//         {
//             e.DisplayEntry();
//         });
//     }

//     public void SaveToFile(string fileName)
//     {
        
//     }

//     public void LoadFromFile(string fileName)
//     {

//     }

// }
// }

using System.Collections.Generic;
using System; 
using System.IO; 
namespace ConsoleApplication1
{
    public class Journal
    {
        private List<Entry> entries = new List<Entry>();

        public Journal()
        {
            
        }

        public void addEntry(Entry entry)
        {
            entries.Add(entry);
        }

        public Entry getEntry(string dateString)
        {
            Entry entry = new Entry("", "");
            entries.ForEach(e =>
            {
                string entryDateString = e.GetDateString();
                if (entryDateString == dateString)
                {
                    entry = e;
                }
            });
            return entry;
        }

        public void DisplayJournal()
        {
            entries.ForEach(e =>
            {
                e.DisplayEntry();
            });
        }

        public void SaveToFile(string fileName)
        {
            Console.WriteLine($"{File.Exists(fileName)}");
            
            List<string> writeLines = new List<string>();
            entries.ForEach(e =>
            {
                Console.WriteLine(e.toLine());
                writeLines.Add(e.toLine());
            });

            File.WriteAllLines(fileName, writeLines);
        }

        public void LoadFromFile(string fileName)
        {
            if (File.Exists(fileName))
            {
                // Store each line in array of strings 
                string[] lines = File.ReadAllLines(fileName);

                foreach (string ln in lines)
                {
                    Console.WriteLine(ln);
                    string[] splt = ln.Split(new string[] { "%%" }, StringSplitOptions.None);
                    string dateString = splt[0];
                    string prompt = splt[1];
                    string msg = splt[2];
                    Entry entry = new Entry(dateString, prompt);
                    entry.SetMessage(msg);
                    addEntry(entry);

                }

            }
        }

    }
}