using EP1_JuanP_Cabezas.ViewModels;
using System.ComponentModel;
using Xamarin.Forms;

namespace EP1_JuanP_Cabezas.Views
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