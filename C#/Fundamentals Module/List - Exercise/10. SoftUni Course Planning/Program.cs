using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main(string[] args)
    {
        List<string> schedule = Console.ReadLine().Split(", ").ToList();

        string command;
        while ((command = Console.ReadLine()) != "course start")
        {
            string[] commandParts = command.Split(':');
            string action = commandParts[0];
            string lessonTitle = commandParts[1];

            if (action == "Add" && !schedule.Contains(lessonTitle))
            {
                schedule.Add(lessonTitle);
            }
            else if (action == "Insert" && !schedule.Contains(lessonTitle))
            {
                int index = int.Parse(commandParts[2]);
                schedule.Insert(index, lessonTitle);
            }
            else if (action == "Remove" && schedule.Contains(lessonTitle))
            {
                schedule.Remove(lessonTitle);
                string exercise = lessonTitle + "-Exercise";
                schedule.Remove(exercise);
            }
            else if (action == "Swap")
            {
                string secondLessonTitle = commandParts[2];
                if (schedule.Contains(lessonTitle) && schedule.Contains(secondLessonTitle))
                {
                    int firstIndex = schedule.IndexOf(lessonTitle);
                    int secondIndex = schedule.IndexOf(secondLessonTitle);
                    schedule[firstIndex] = secondLessonTitle;
                    schedule[secondIndex] = lessonTitle;

                    string firstExercise = lessonTitle + "-Exercise";
                    string secondExercise = secondLessonTitle + "-Exercise";

                    if (schedule.Contains(firstExercise))
                    {
                        int firstExerciseIndex = schedule.IndexOf(firstExercise);
                        schedule.RemoveAt(firstExerciseIndex);
                        schedule.Insert(secondIndex + 1, firstExercise);
                    }

                    if (schedule.Contains(secondExercise))
                    {
                        int secondExerciseIndex = schedule.IndexOf(secondExercise);
                        schedule.RemoveAt(secondExerciseIndex);
                        schedule.Insert(firstIndex + 1, secondExercise);
                    }
                }
            }
            else if (action == "Exercise")
            {
                string exercise = lessonTitle + "-Exercise";
                if (schedule.Contains(lessonTitle) && !schedule.Contains(exercise))
                {
                    int lessonIndex = schedule.IndexOf(lessonTitle);
                    schedule.Insert(lessonIndex + 1, exercise);
                }
                else if (!schedule.Contains(lessonTitle))
                {
                    schedule.Add(lessonTitle);
                    schedule.Add(exercise);
                }
            }
        }

        for (int i = 0; i < schedule.Count; i++)
        {
            Console.WriteLine($"{i + 1}.{schedule[i]}");
        }
    }
}
