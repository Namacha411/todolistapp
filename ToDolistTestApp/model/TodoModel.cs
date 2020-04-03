using System;
using SQLite;
using System.Collections.Generic;

namespace ToDolistTestApp.Models
{
    public class Todo
    {
        [PrimaryKey, AutoIncrement]
        public int ID { get; set; }
        public bool isChecked { get; set; }
        public string title { get; set; }
        public string note { get; set; }
        public DateTime dateTime { get; set; }
    }
}