using System;

public class TodoItem
{
	public TodoItem()
	{
        public int Id { get; set; }
    public string Title { get; set; }
    public string Description { get; set; }
    public DateTime DueDate { get; set; }
    public bool IsComplicated { get; set; } 

    public TodoItem(int id, string title, string description, DateTime dueDate, bool isComplicated)
    {
        Id = id;
        Title = title;
        Description = description;
        DueDate = dueDate;
        IsComplicated = isComplicated;
    }
    class program
    {
        static int nextId = 1;

        
        static List<TodoItem> todoList = new List<TodoItem>();

        static void main()
        {
            AddTodo();
            Console.WriteLine();
            Console.WriteLine("=== SPISUK SUS ZADACHI ===");
            foreach (var item in todoList)
            {
                Console.WriteLine($"ID: {item.Id}");
                Console.WriteLine($"ZAGLAVIE: {item.Title}");
                Console.WriteLine($"OPISANIE: {item.Description}");
                Console.WriteLine($"KRAEN SROK: {item.DueDate:dd.MM.yyyy}");
                Console.WriteLine($"SLOJNA LIE : {item.IsComplicated}");
            }
        }
        public string void AddTodo()
        {
            Console.Clear();
            Console.WriteLine("=== DOBAVQNE NA NOVA ZADACHA ===");
            Console.WriteLine($"AVTOMATICHNO ID: {nextId}");

            Console.Write("VUVEDETE ZAGLAVIE: ");
            string title = Console.ReadLine();

            Console.Write("VUVEDETE OPISANIE: ");
            string description = Console.ReadLine();

            DateTime dueDate;
            Console.Write("KRAEN SROK (dd.MM.yyyy): ");
            while (!DateTime.TryParse(Console.ReadLine(), out dueDate))
            {
                Console.WriteLine("NEVALIDNA DATA OPITAITE OTNOVO.");
                Console.Write("KRAEN SROK (dd.MM.yyyy): ");
            }
            bool isComplicated;
            Console.Write("SLOJNA LI E ZADACHATA? (true/false): ");
            while (!bool.TryParse(Console.ReadLine(), out isComplicated))
            {
                Console.WriteLine("MOLQ VUVEDETE true/ false.");
                Console.Write("SLOJNA LI E ZADACHATA? (true/false): ");
            }
            TodoItem newItem = new TodoItem(nextId, title, description, dueDate, isComplicated);
            todoList.Add(newItem);

            nextId++;
        }
    }

}
