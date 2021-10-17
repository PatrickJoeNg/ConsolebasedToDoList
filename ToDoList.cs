using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToDoWithEnums
{
    class ToDoList
    {
        // create a new string list of things to do called Todos
        private readonly List<ToDo> todos = new List<ToDo>();

        // method will print list of Todos
        public void PrintTodos()
        {
            if (todos.Count == 0)
            {
                Console.WriteLine("\nThe Todo List is empty...");
            }
            else
            {
                Console.WriteLine("\nHeres what to do Today: ");
                int i = 1;
                foreach (ToDo todo in todos)
                {
                    Console.WriteLine($"{i++}. {todo.ThingToDo}");
                }
            }
        }

        // Adds a todo to list
        public void AddTodo()
        {
            Console.WriteLine("\nAdd a task...");
            string task = Console.ReadLine();
            ToDo todo = new ToDo(task);
            todos.Add(todo);
        }

        // Removes the todo of choice
        // and account for number of task
        public void RemoveToDo()
        {
            Console.WriteLine("\nEnter the number of the Todo you want to remove:");
            if (int.TryParse(Console.ReadKey().KeyChar.ToString(), out int taskNumber) &&
                (taskNumber >=1) && (taskNumber <= todos.Count))
            {
                Console.WriteLine($"\nRemoving {todos[taskNumber - 1].ThingToDo}");
                todos.RemoveAt(taskNumber - 1);
            }
        }
    }
}
