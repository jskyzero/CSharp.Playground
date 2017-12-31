using System;

namespace ConsoleApplication
{
  public class TodoUI
  {
    private TodoManage TodoData;
    public TodoUI()
    {
      TodoData = new TodoManage();
    }
    public void MainFunc()
    {
      string argv = Console.ReadLine();
      while (argv != null && argv.ToLower() != "exit")
      {
        ExecArgv(argv.Split(' '));
        argv = Console.ReadLine();
      }
      TodoData.Exit();
    }
    public void ExecArgv(string[] argv)
    {
      switch (argv[0].ToLower())
      {
        case "add":
          TodoData.AddTodo(new Todo(DateTime.Now, argv[1], argv[2]));
          break;
        case "del":
        case "delete":
        case "remove":
          TodoData.DeleteTodo(new Todo { title = argv[1] });
          break;
        case "list":
        case "ls":
        case "all":
          TodoData.ListTodo();
          break;
        default:
          Console.WriteLine("");
          break;
      }
    }
  }
}