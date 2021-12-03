using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Ejercicio2
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
            Item1.Clicked += async (sender,e) =>
            {
                await Navigation.PushAsync(new Page1());
            };
            Item2.Clicked += async (sender, e) => { await Navigation.PushAsync(new TabbedPage1()); };
            Item3.Clicked += async (sender, e) => { await Navigation.PushAsync(new CarouselPage1()); };
            Item4.Clicked += async (sender, e) => { /*para llamar al popup await */ await Navigation.PushModalAsync(new ModalPage1()); };
            Item5.Clicked += async (sender, e) =>
            {/*par llamar un popup de tipo confirm*/
                var answer = await DisplayAlert("Pregunta", "te gustaria jugar", "Si", "No");
                Debug.WriteLine("Answer: " + answer);
            };
        }
    }
}
