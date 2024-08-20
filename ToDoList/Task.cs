using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToDoList
{
    public class Task
    {
    

        private string Title { get; set; }
         private string Description { get; set; }

        private DateTime DueDate { get; set; }

        private bool IsCompleted { get; set; }


        public Task(string title, string description, DateTime dueDate)
        {
            Title = title;
            Description = description;
            DueDate = dueDate;
            IsCompleted = false;
        }


        public void DisplayTask() {

            Console.WriteLine("Title: " + Title);
            Console.WriteLine("Description: " + Description);
            Console.WriteLine("DueDate: " + DueDate);
            Console.WriteLine(" IsCompleted: " + IsCompleted);

        }


        public void MarkTaskCompleted() { 
          this.IsCompleted = true;
        
        }

    }
}
