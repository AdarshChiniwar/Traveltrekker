using Traveltrekker.ViewModels;

namespace Traveltrekker
{
    public partial class MainPage : ContentPage
    {


        public MainPage()
        {
            InitializeComponent();
            BindingContext = new MainPageViewModel();
        }

     
    }

}
