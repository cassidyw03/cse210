using System;
using System.Collections.Generic;

namespace ConsoleApplication1{

public class Prompt
    {
        private Random random = new Random();

        public Prompt()
        {

        }

        public string GetPrompt()
        {
            List<string> prompts = new List<string>
            {
             "What are you most proud of recently?", "What are you grateful for today?", "Who did you reach out to today? Who reached out to you?", "What made you happy today?", "Write about a memory you have relating to the color blue.", "When were you most happy this week?", "Write about a person who always makes you laugh", "Describe your favorite mundane moment of the day.", "Who or what in your life are you happy to have let go?", "Write about a positive interaction you had with a stranger.", "What do you feel anxious about right now?"
             };
             int index = random.Next(prompts.Count);
             return prompts[index];
        }
        }
        }
    // {
    //     int randomIndex = random.Next(prompts.Count);
    //     return prompts[randomIndex];
    // }