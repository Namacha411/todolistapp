using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

public class TodoData
{
    private string title { get; set; }
    private string note { get; set; }
    private DateTime dateTime { get; set; }
    private string place { get; set; }
    private string url { get; set; }
    private ColorTag ColorTag { get; set; }

    private bool isDone { get; set; }

    TodoData(string note, DateTime dateTime, string place, string url, ColorTag colorTag)
    {
        this.note = note;
        this.dateTime = dateTime;
        this.place = place;
        this.url = url;
        this.ColorTag = ColorTag;
    }
}

public enum ColorTag
{
    yellow,
    green,
    blue,
    purple,
    red,
    orange
}