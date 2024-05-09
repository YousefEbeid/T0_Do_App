using System;
using System.Collections.Generic;
using System.Linq;

// Define a class countain a all task item 
class TaskItem
{
    public string Title { get; set; }
    public string Description { get; set; }
    public DateTime DueDate { get; set; }
    public string Priority { get; set; }
    public bool Completed { get; set; }
}

class Program
{
    // creat a list of the class TaskItem to stor all task item in it 
    static List<TaskItem> tasks = new List<TaskItem>();

    static void Main(string[] args)
    {
        Console.WriteLine("Welcome to the To-Do List Application!");
        // Main screen that will show to the user in every opreation
        while (true)
        {
            Console.WriteLine("\nPlease select an option:");
            Console.WriteLine("1. Add a task");
            Console.WriteLine("2. List all tasks");
            Console.WriteLine("3. Edit a task");
            Console.WriteLine("4. Mark a task as completed");
            Console.WriteLine("5. Delete a task");
            Console.WriteLine("6. Set task priority");
            Console.WriteLine("7. Exit");

            string choice = Console.ReadLine();//read the user input and handel it to do the opreation that the user want to do
            
            switch (choice)
            {
                case "1":
                    AddTask();
                    break;
                case "2":
                    ListTasks();
                    break;
                case "3":
                    EditTask();
                    break;
                case "4":
                    Completed();
                    break;
                case "5":
                    Delete();
                    break;
                case "6":
                    SetTaskPriority();
                    break;
                case "7":
                    Console.WriteLine("Thank you for using the To-Do List Application. Goodbye!");
                    return;
                default:
                    Console.WriteLine("Invalid option. Please try again.");
                    break;
            }
        }
    }
    // in this part every choise in the display menu has Method to handel it 
    // Method 1 to Add a new task 
    static void AddTask()
    {
        TaskItem task = new TaskItem();
        
        Console.WriteLine("Enter task details:");
        Console.Write("Title: ");
        task.Title = Console.ReadLine();
        Console.Write("Description: ");
        task.Description = Console.ReadLine();
        Console.Write("Due date (YYYY-MM-DD): ");
        task.DueDate = DateTime.Parse(Console.ReadLine());
        Console.Write("Priority (high, medium, low): ");
        task.Priority = Console.ReadLine();
        task.Completed = false;

        tasks.Add(task);
        Console.WriteLine("Task added successfully!");
    }


    //Method to show list oreard by priority   
    static void ListTasks()
    {
        if (tasks.Count == 0)
        {
            Console.WriteLine("No tasks found.");
            return;
        }
        //  sort tasks by proiority 
        var sortedTasks = tasks.OrderBy(t => t.Priority);
        
        // show task in format 
        Console.WriteLine("\nID | Title | Due Date | Priority | Completed");
        foreach (var task in sortedTasks)
        {
            Console.WriteLine($"{tasks.IndexOf(task) + 1} | {task.Title} | {task.DueDate.ToString("yyyy-MM-dd")} | {task.Priority} | {(task.Completed ? "Yes" : "No")}");
        }
    }
    //Metho to edit a task
    static void EditTask()
    {
        Console.Write("Enter the task ID to edit: ");
        int taskId = int.Parse(Console.ReadLine()) - 1;

        if (taskId < 0 || taskId >= tasks.Count)
        {
            Console.WriteLine("Invalid task ID.");
            return;
        }

        TaskItem task = tasks[taskId];

        Console.WriteLine("\nEnter new task details:");
        Console.Write("Title: ");
        task.Title = Console.ReadLine();
        Console.Write("Description: ");
        task.Description = Console.ReadLine();
        Console.Write("Due date (YYYY-MM-DD): ");
        task.DueDate = DateTime.Parse(Console.ReadLine());
        Console.Write("Priority (high, medium, low): ");
        task.Priority = Console.ReadLine();

        Console.WriteLine("Task updated successfully!");
    }


    //Method to Make task  Completed  
    static void Completed()
    {
        Console.Write("Enter the task ID to mark as completed: ");
        int taskId = int.Parse(Console.ReadLine()) - 1;

        if (taskId < 0 || taskId >= tasks.Count)
        {
            Console.WriteLine("Invalid task ID.");
            return;
        }

        tasks[taskId].Completed = true;
        Console.WriteLine("Task marked as completed!");
    }


    //Method to delete a task
    static void Delete()
    {
        Console.Write("Enter the task ID to delete: ");
        int taskId = int.Parse(Console.ReadLine()) - 1;

        if (taskId < 0 || taskId >= tasks.Count)
        {
            Console.WriteLine("Invalid task ID.");
            return;
        }

        tasks.RemoveAt(taskId);
        Console.WriteLine("Task deleted successfully!");
    }
    // Method to change task Priority
    static void SetTaskPriority()
    {
        Console.Write("Enter the task ID to set priority: ");
        int taskId = int.Parse(Console.ReadLine()) - 1;

        if (taskId < 0 || taskId >= tasks.Count)
        {
            Console.WriteLine("Invalid task ID.");
            return;
        }
       // int taskID = Convert.ToInt32(Console.ReadLine());

        Console.Write("Enter the new priority (high, medium, low): ");
        string newPriority = Console.ReadLine();

        tasks[taskId].Priority = newPriority;
        Console.WriteLine("Priority of task set successfully!");
    }
}
