using MyFirstXamrainApp.ViewModels;
using System.ComponentModel;
using Xamarin.Forms;

namespace MyFirstXamrainApp.Views
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