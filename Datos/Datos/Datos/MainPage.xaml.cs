using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Datos
{

    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
            btnpagina2.Clicked += Btnpagina2_Clicked;
        }

        private void Btnpagina2_Clicked(object sender, EventArgs e)
        {
            Navigation.PushModalAsync(new Page2(txtusername.Text,txtape.Text));
            
        }
    }
}
