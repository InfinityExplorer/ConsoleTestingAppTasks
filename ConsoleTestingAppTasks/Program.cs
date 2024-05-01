using System;
using System.Collections.Generic;
using System.Linq;

namespace ConsoleTestingAppTasks
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Успешно");
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
        public class Task
        {
            public string Name { get; set; }
            public int Priority { get; set; }
            public DateTime DueDate { get; set; }
        }

        public class TaskManager
        {
            private List<Task> tasks;

            public TaskManager()
            {
                tasks = new List<Task>();
            }

            public void AddTask(Task task)
            {
                tasks.Add(task);
            }

            public void RemoveTask(Task task)
            {
                tasks.Remove(task);
            }

            public List<Task> GetTasks()
            {
                return tasks;
            }

            public void DisplayTasks()
            {
                foreach (var task in tasks)
                {
                    Console.WriteLine($"Task: {task.Name}, Priority: {task.Priority}, Due Date: {task.DueDate}");
                }
            }
        }

        public class TaskUI
        {
            private TaskManager taskManager;

            public TaskUI(TaskManager manager)
            {
                taskManager = manager;
            }

            public void AddTaskUI()
            {
                // Example implementation for adding task through UI
                Task newTask = new Task();
                Console.WriteLine("Enter task name:");
                newTask.Name = Console.ReadLine();
                Console.WriteLine("Enter task priority:");
                newTask.Priority = int.Parse(Console.ReadLine());
                Console.WriteLine("Enter task due date (YYYY-MM-DD):");
                newTask.DueDate = DateTime.Parse(Console.ReadLine());
                taskManager.AddTask(newTask);
            }

            public void RemoveTaskUI()
            {
                // Code for accepting user input for task removal
            }

            public void DisplayTasksUI()
            {
                taskManager.DisplayTasks();
            }
        }

        public class TaskScheduler
        {
            private TaskManager taskManager;

            public TaskScheduler(TaskManager manager)
            {
                taskManager = manager;
            }

            public void ScheduleTasks()
            {
                var tasksToSchedule = taskManager.GetTasks().OrderBy(t => t.Priority).ThenBy(t => t.DueDate);
                foreach (var task in tasksToSchedule)
                {
                    // Implement scheduling logic here
                    Console.WriteLine($"Task '{task.Name}' scheduled.");
                }
            }
        }
    }
}
