using PM02P3MVVM.ViewModels;
using System.ComponentModel;
using Xamarin.Forms;

namespace PM02P3MVVM.Views
{
    public partial class ItemDetailPage : ContentPage
    {
        public ItemDetailPage()
        {
            InitializeComponent();
            BindingContext = new ItemDetailViewModel();
        }
    }
}