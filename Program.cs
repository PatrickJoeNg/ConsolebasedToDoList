using System;

namespace ToDoWithEnums
{
    class Program
    {
        static ToDoList todoList = new ToDoList();

        static void Main(string[] args)
        {
            bool state = true;
            while (state)
            {
                todoList.PrintTodos();
                Console.WriteLine("\nPress 'a' to add or 'r' to remove a todo." +
                    "\nPress any other key to exit.");
                char key = Console.ReadKey().KeyChar;

                switch (key)
                {
                    case 'a':
                    case 'A':
                        todoList.AddTodo();
                        break;
                    case 'r':
                    case 'R':
                        todoList.RemoveToDo();
                        break;
                    default:
                        state = false;
                        break;
                }
            }
        }
    }
}
