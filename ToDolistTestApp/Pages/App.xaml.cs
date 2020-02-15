using System;
using System.IO;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using ToDolistTestApp.Data;

namespace ToDolistTestApp
{
    public partial class App : Application
    {
        static TodoDatabase database;

        public static TodoDatabase Database
        {
            get
            {
                if (database == null)
                {
                    database = new TodoDatabase(
                        Path.Combine(
                            Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData),
                            "Notes.db3"));
                }
                return database;
            }
        }

        public App()
        {
            InitializeComponent();

            MainPage = new NavigationPage(new MainPage());
        }

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
