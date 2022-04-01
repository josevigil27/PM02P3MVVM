using PM02P3MVVM.ViewModels;
using PM02P3MVVM.Views;
using System;
using System.Collections.Generic;
using Xamarin.Forms;

namespace PM02P3MVVM
{
    public partial class AppShell : Xamarin.Forms.Shell
    {
        public AppShell()
        {
            InitializeComponent();
            Routing.RegisterRoute(nameof(ItemDetailPage), typeof(ItemDetailPage));
            Routing.RegisterRoute(nameof(AddProductPage), typeof(AddProductPage));
        }

        private async void OnMenuItemClicked(object sender, EventArgs e)
        {
            await Shell.Current.GoToAsync("//LoginPage");
        }
    }
}
