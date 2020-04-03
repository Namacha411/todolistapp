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
            Todo todo = BindingContext as Todo;
            todo.dateTime = DateTime.Now;
            todo.isChecked = false;
            await App.Database.SaveTodoAsync(todo);
            await Navigation.PopAsync();
        }

        async void OnDeleteButtonClicked(object sender, EventArgs e)
        {
            Todo todo = BindingContext as Todo;
            await App.Database.DeleteTodoAsync(todo);
            await Navigation.PopAsync();
        }
    }
}
