using System;
using Xamarin.Forms;

namespace AppMapProject1.Views
{
    public partial class MainPage : TabbedPage
    {
        public MainPage()
        {
            InitializeComponent();
        }
        private void Button_OnClicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new TabChild());
        }
    }
}