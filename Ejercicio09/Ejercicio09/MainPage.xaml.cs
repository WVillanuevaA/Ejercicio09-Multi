using System;
using Xamarin.Forms;

namespace Ejercicio09
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void DynamicDemo_Clicked(object sender, EventArgs e)
        {
            var dynamicDemo = (ContentPage)Resources["DynamicDemo"];
            Navigation.PushAsync(dynamicDemo);
        }

        private void ExplicitControlDemo_Clicked(object sender, EventArgs e)
        {
            var explicitControlDemo = (ContentPage)Resources["ExplicitControlDemo"];
            Navigation.PushAsync(explicitControlDemo);
        }

        private void GlobalDemo_Clicked(object sender, EventArgs e)
        {
            var globalDemo = (ContentPage)Resources["GlobalDemo"];
            Navigation.PushAsync(globalDemo);
        }

        private void ImplicitControlDemo_Clicked(object sender, EventArgs e)
        {
            var implicitControlDemo = (ContentPage)Resources["ImplicitControlDemo"];
            Navigation.PushAsync(implicitControlDemo);
        }
    }
}
