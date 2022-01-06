using System.ComponentModel;
using test1.ViewModels;
using Xamarin.Forms;

namespace test1.Views
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