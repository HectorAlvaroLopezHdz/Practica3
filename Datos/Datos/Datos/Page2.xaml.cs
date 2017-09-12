using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Datos
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Page2 : ContentPage
    {
        public Page2(string username ,string apellidos)
        {
            InitializeComponent();
            txtusername.Text = username;
            txtape.Text = apellidos;
            btnpagina1.Clicked += Btnpagina1_Clicked;
        }

        private void Btnpagina1_Clicked(object sender, EventArgs e)
        {
            Navigation.PushModalAsync(new MainPage());
        }
    }
}