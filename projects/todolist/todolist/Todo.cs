using System;

namespace ConsoleApplication
{
public class Todo : IEquatable<Todo>
    {
        private DateTime time_;
        private string   title_;
        private string   content_;
        public Todo(){
            time_ = DateTime.Now;
            title_ = "";
            content_ = "";
        }
        public Todo(DateTime Time, string Title, string Content)
        {
            time_  = Time;
            title_ = Title;
            content_ = Content;
        }
        public DateTime time{
            get{
                return time_;
            }
            set{
                time_ = value;
            }
        }
        public string title{
            get{
                return title_;
            }
            set{
                title_ = value;
            }
        }

        public string content{
            get{
                return content_;
            }
            set{
                content_ = value;
            }
        }

        public bool Equals(Todo other)
        {
            if (other == null) return false;
            return (this.title.Equals(other.title));
        }

        public override string ToString()
        {
            return time_.ToString("yy/MM/dd HH:MM") + " " + title_ + " " + content_;
        }
    }
}
