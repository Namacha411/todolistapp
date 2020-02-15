using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using ToDolistTestApp.Models;

namespace ToDolistTestApp
{
    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
    [DesignTimeVisible(false)]
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            Title = "メインページ";

            InitializeComponent();
        }

        protected override async void OnAppearing()
        {
            base.OnAppearing();

            listView.ItemsSource = await App.Database.GetNotesAsync();
        }

        async void OnAddToDoListButtonClicked(Object sender, EventArgs e)
        {
            await Navigation.PushAsync(
                new AddToDoListPage
                {
                    BindingContext = new Todo()
                });
        }

        async void OnListViewItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            if (e.SelectedItem != null)
            {
                await Navigation.PushAsync(new AddToDoListPage
                {
                    BindingContext = e.SelectedItem as Todo
                });
            }
        }
    }
}
