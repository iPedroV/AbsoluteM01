using MailChimp.Net.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using Image = Xamarin.Forms.Image;

namespace AbsoluteM01
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Page2 : ContentPage
    {
        public Page2()
        {
            InitializeComponent();

            AbsoluteLayout abs = new AbsoluteLayout();

            Label lb1 = new Label
            {
                Text = "Heróis da Marvel",
                FontSize = 30,
                FontAttributes = FontAttributes.Bold,
               
                HorizontalTextAlignment = TextAlignment.Center
            };

            abs.Children.Add(lb1, new Rectangle(0.5, 30, 400, 80),
                AbsoluteLayoutFlags.XProportional);

            Image img2 = new Image
            {
                Source = "bebeTablet.jpg"
            };
            abs.Children.Add(img2, new Rectangle(0.5, 200, 200, 200),
                    AbsoluteLayoutFlags.XProportional);

            img1.Source = "bebeTablet.jpg";

            abs.Children.Add(img1, new Rectangle(0.5, 500, 150, 150));

            var tap1 = new TapGestureRecognizer();

            img1.GestureRecognizers.Add(tap1);

            tap1.Tapped += Tap1_Tapped;

            Content = abs;
        }

        private async void Tap1_Tapped(object sender, EventArgs e)
        {
            img1.Opacity = 0.5;
            await Task.Delay(200);
            img1.Opacity = 1;
            await Navigation.PopToRootAsync();
        }
    }
}