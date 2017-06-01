using System;
using System.Collections.Generic;

namespace ConsoleApplication
{
    class TodoManage
    {
        private List<Todo> TodoList;
        public  TodoManage()
        {
            TodoList = new List<Todo>();
        }

        public void AddTodo(Todo NewTodo)
        {
            TodoList.Add(NewTodo);
        }

        public void DeleteTodo(Todo NewTodo)
        {
            TodoList.Remove(NewTodo);
        }

        public void ListTodo()
        {
            foreach(Todo EachTodo in TodoList)
            {
                if (EachTodo.Equals(new Todo{ Title = "1"}))
                {
                Console.WriteLine(EachTodo.ToString());
                }
            }
        }

    }
}