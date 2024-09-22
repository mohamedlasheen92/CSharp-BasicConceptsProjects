using System;

namespace Task_Tracker
{
  internal class Program
  {
    private static string[] tasks = new string[15];
    private static sbyte lastIndex = -1;
    static void Main(string[] args)
    {
      //greeting to the User.
      Console.WriteLine("Welcome to My Task Tracker");

      string choice;

      Console.WriteLine("--------------------------");
      Console.WriteLine("1. Add a task");
      Console.WriteLine("2. View tasks");
      Console.WriteLine("3. Mark a task as completed");
      Console.WriteLine("4. Remove a task");
      Console.WriteLine("5. Exit");
      Console.WriteLine("--------------------------");

      while (true)
      {

        Console.Write("Enter your Choice from 1 to 5: ");
        choice = Console.ReadLine();

        switch (choice)
        {
          case "1":
            AddTask();
            break;
          case "2":
            ViewTasks();
            break;
          case "3":
            MarkAsCompleted();
            break;
          case "4":
            RemoveTask();
            break;
          case "5":
            Console.WriteLine("\n\nTask Tracker session ended. Have a great day!");
            Environment.Exit(0);
            break;

          default:
            Console.WriteLine("Please Enter a Valid Choice");
            break;
        }
        Console.WriteLine();
      }


    }
    private static void AddTask()
    {
      Console.Write("Enter a Task: ");
      string newTask = Console.ReadLine();

      lastIndex++;

      tasks[lastIndex] = newTask;

      Console.WriteLine("The task has been added to your tasks list.");
    }
    private static void ViewTasks()
    {
      Console.WriteLine("Tasks List:");
      for (int i = 0; i <= lastIndex; i++)
      {
        Console.WriteLine($"{i + 1}. {tasks[i]}");
      }
    }
    private static void MarkAsCompleted()
    {
      Console.Write("Enter the task number to mark it as complete: ");
      byte completedTask = Byte.Parse(Console.ReadLine());

      tasks[completedTask - 1] = tasks[completedTask - 1] + " --COMPLETED";
    }
    private static void RemoveTask()
    {
      Console.Write("Enter the number of the task you want to remove: ");
      byte removedTaskNumber = Byte.Parse(Console.ReadLine());

      for (int i = removedTaskNumber - 1; i <= lastIndex; i++)
      {
        tasks[i] = tasks[i + 1];
      }
      lastIndex--;

    }
  }
}
