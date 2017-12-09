using System;

namespace ConsoleApplication
{
    public class Todo : IEquatable<Todo>
    {
        private DateTime _Time;
        private string   _Title;
        private string   _Content;
        public Todo(){
            _Time = DateTime.Now;
            _Title = "";
            _Content = "";
        }
        public Todo(DateTime Time, string Title, string Content)
        {
            _Time  = Time;
            _Title = Title;
            _Content = Content;
        }
        public DateTime Time{
            get{
                return Time;
            }
            set{
                Time = value;
            }
        }
        public string Title{
            get{
                return _Title;
            }
            set{
                _Title = value;
            }
        }

        public string Content{
            get{
                return _Content;
            }
            set{
                _Content = value;
            }
        }

        public bool Equals(Todo other)
        {
            if (other == null) return false;
            return (this.Title.Equals(other.Title));
        }

        public override string ToString()
        {
            return _Time.ToString("yy/MM/dd HH:MM") + " " + _Title + " " + _Content;
        }
    }
}
