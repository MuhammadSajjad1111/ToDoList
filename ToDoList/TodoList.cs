using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToDoList
{
    public class TodoList
    {

        private List<Task> todolist { get; set; }


        public TodoList()
        {
            todolist = new List<Task>();
        }


        public void AddTask(Task task)
        {

            if (task != null)
            {
                todolist.Add(task);
            }


        }


        public void RemoveTask(Task task)
        {
            if (task != null)
            {
                todolist.Remove(task);
             
            }
        }


        public void displayTasks()
        {
            for (int i = 0; i < todolist.Count; i++) { 

                         Task task = todolist[i];

                          task.DisplayTask();
            
               
            }
        }


        public void MarkTaskCompleted(Task task)
        {

            if (task != null)
            {
                task.MarkTaskCompleted();
            }
        }
    }
}
