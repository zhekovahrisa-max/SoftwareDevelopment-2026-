using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exception_project
{
    public class TodoItem
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
        private static void AddTodo()
        {
            Console.Clear();
        }
    }

}
