using CardGame.ViewModels;
using System.ComponentModel;
using Xamarin.Forms;

namespace CardGame.Views
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