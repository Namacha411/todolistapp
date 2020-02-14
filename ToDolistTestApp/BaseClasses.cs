using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

public class TodoData
{
    private string memo { get; set; }
    private Date date { get; set; }
    private string place { get; set; }
    private string url { get; set; }
    private Tag tag { get; set; }

    private bool isDone;

    //コンストラクター
    TodoData(string memo, Date date, string place, string url, Tag tag)
    {
        this.memo = memo;
        this.date = date;
        this.place = place;
        this.url = url;
        this.tag = tag;
    }
}

 public class Date
{
    private int year;
    private int month;
    private int day;
    public DayOfWeek DayOfWeek { get; set; }

    public int Year
    {
        get { return year; }
        set { if (value > 0) year = value; }
    }

    public int Month
    {
        get { return month; }
        set { if (value >= 1 && value <= 12) month = value; }
    }

    public int Day
    {
        get { return day; }
        set { if (value >= 1 && value <= 31) day = value; }
    }
}

public enum DayOfWeek
{
    Saturday,
    Sunday,
    Monday,
    Tuesday,
    Wednesday,
    Thursday,
    Friday
}

public enum Tag
{
    tag1,
    tag2,
    tag3,
    tag4,
    tag5
}