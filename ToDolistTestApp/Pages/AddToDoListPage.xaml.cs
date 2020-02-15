using System;
using System.Collections.Generic;
using ToDolistTestApp.Models;

using Xamarin.Forms;

namespace ToDolistTestApp
{
    public partial class AddToDoListPage : ContentPage
    {
        public AddToDoListPage()
        {
            Title = "予定を追加";

            InitializeComponent();
        }

        async void OnSaveButtonClicked(object sender, EventArgs e)
        {
            Todo todo = (Todo)BindingContext;
            todo.dateTime = DateTime.UtcNow;
            await App.Database.SaveNoteAsync(todo);
            await Navigation.PopAsync();
        }
    }
}
