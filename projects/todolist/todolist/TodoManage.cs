using System;
using System.IO;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace ConsoleApplication
{
  class TodoManage
  {
    private List<Todo> todoList;
    private const string filePath = "notes.json";
    public TodoManage()
    {
      ReadFromFile();
    }
    public void Exit()
    {
      SaveToFile();
    }

    private void SaveToFile()
    {
      var json = JsonConvert.SerializeObject(todoList);
      File.WriteAllText(filePath, json);
    }

    private void ReadFromFile()
    {
      try
      {
        todoList = JsonConvert.DeserializeObject<List<Todo>>(
          File.ReadAllText(filePath));
      }
      catch (Exception ex)
      {
        if (ex is System.IO.IOException ||
            ex is Newtonsoft.Json.JsonSerializationException)
        {
          todoList = new List<Todo>();
          return;
        }
        throw;
      }

    }

    public void AddTodo(Todo NewTodo)
    {
      todoList.Add(NewTodo);
    }

    public void DeleteTodo(Todo NewTodo)
    {
      todoList.Remove(NewTodo);
    }

    public void ListTodo()
    {
      foreach (Todo EachTodo in todoList)
      {
        Console.WriteLine(EachTodo.ToString());
      }
    }

  }
}