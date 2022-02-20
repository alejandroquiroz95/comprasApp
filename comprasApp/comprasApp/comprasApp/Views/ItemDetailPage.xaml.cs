using comprasApp.ViewModels;
using System.ComponentModel;
using Xamarin.Forms;

namespace comprasApp.Views
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