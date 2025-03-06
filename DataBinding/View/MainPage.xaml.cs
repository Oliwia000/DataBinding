using System.Collections.ObjectModel;
using System.Windows.Input;
using DataBinding.ViewModel;

namespace DataBinding
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
            BindingContext = new MainViewModel();
        }
    }
}