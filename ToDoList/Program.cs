

using System;

namespace ToDoList {


    class Program {

        static void Main(string[] args) {
        
           Task task1=new Task("Task1", "Task1 description" , new DateTime(2024, 8, 30, 17, 0, 0));

            Task task2 = new Task("Task2", "Task2 description", new DateTime(2024, 8, 30, 17, 0, 0));


            task1.MarkTaskCompleted();

            //task1.DisplayTask();


            TodoList todo=new TodoList();

            todo.AddTask(task1);
            todo.AddTask(task2);

           

            todo.RemoveTask(task1);

            todo.displayTasks();




        }
    
    
    }



}
