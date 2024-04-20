using System;
using System.Collections.Generic;

namespace ConsoleTestingAppTasks
{
    internal class Program
    {
        static void Main(string[] args)
        {
            TaskList taskList = new TaskList();
            taskList.AddTask("Buy groceries");
            taskList.AddTask("Do laundry");
            taskList.DisplayTasks();
        }
    }

    public class TaskList
    {
        private List<string> tasks;

        public TaskList()
        {
            tasks = new List<string>();
        }

        public void AddTask(string task)
        {
            if (!tasks.Contains(task))
            {
                tasks.Add(task);
                Console.WriteLine($"Task \"{task}\" added.");
            }
            else
            {
                Console.WriteLine($"Task \"{task}\" already exists.");
            }
        }
        public bool ContainsTask(string task)
        {
            return tasks.Contains(task);
        }

        public void RemoveTask(string task)
        {
            if (tasks.Contains(task))
            {
                tasks.Remove(task);
                Console.WriteLine($"Task \"{task}\" removed.");
            }
            else
            {
                Console.WriteLine($"Task \"{task}\" not found.");
            }
        }

        public void MarkTaskAsDone(string task)
        {
            if (tasks.Contains(task))
            {
                tasks.Remove(task);
                Console.WriteLine($"Task \"{task}\" marked as done.");
            }
            else
            {
                Console.WriteLine($"Task \"{task}\" not found.");
            }
        }

        public void DisplayTasks()
        {
            if (tasks.Count == 0)
            {
                Console.WriteLine("No tasks in the list.");
            }
            else
            {
                Console.WriteLine("Tasks:");
                foreach (var task in tasks)
                {
                    Console.WriteLine("- " + task);
                }
            }
        }
    }
}
