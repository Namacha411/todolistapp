using System;
using SQLite;

namespace ToDolistTestApp.Models
{
    public class Todo
    {
        [PrimaryKey, AutoIncrement]
        public int ID { get; set; }
        public string title { get; set; }
        public string note { get; set; }
        public DateTime dateTime { get; set; }
        public string place { get; set; }
        public string url { get; set; }
        //public ColorTag ColorTag { get; set; }
    }
}