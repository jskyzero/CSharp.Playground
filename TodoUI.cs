using System;

namespace ConsoleApplication
{
    class TodoUI
    {
        private TodoManage TodoData;
        public TodoUI()
        {
            TodoData  = new TodoManage();
        }

        public void MainFunc()
        {
            string argv = "";
            while(argv.ToLower() != "exit") {
                argv = Console.ReadLine();
                ExecArgv(argv.Split(' '));
            }
        }
        public void ExecArgv(string[] argv)
        {
            switch(argv[0].ToLower())
            {
                case "add":
                    TodoData.AddTodo(new Todo(DateTime.Now, argv[1], argv[2]));
                    break;
                case "del":
                case "delete":
                case "remove":
                    TodoData.DeleteTodo(new Todo{ Title = argv[1]});
                    break;
                case "list":
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