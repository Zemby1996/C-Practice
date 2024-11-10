namespace ListTask
{
    public class TaskManager
    {
        public List<string> tasks = new List<string>();

        public void AddTask(string task)
        {
            tasks.Add(task);
            Console.WriteLine($"Task '{task}' has been added.");

        }

        public void RemoveTask(string task)
        {
            tasks.Remove(task);
            Console.WriteLine($"Task '{task}' has been removed.");
        }

        public List<string> GetTasks()
        {
            Console.WriteLine("Tasks: ");

            foreach (string task in tasks)
            {
                Console.WriteLine($"{task}, ");
            }
            Console.WriteLine();
            
            return tasks;
        }

        static void Main(string[] args)
        {
            TaskManager taskManager = new TaskManager();

            taskManager.AddTask("Zrobić zakupy");
            taskManager.AddTask("Napisać raport");

            taskManager.GetTasks();

            taskManager.RemoveTask("Zrobić zakupy");

            taskManager.GetTasks();

        }
    }

   
}
