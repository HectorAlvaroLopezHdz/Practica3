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
            Prueba.Items.Add("Ingeniería en Sistemas Computacionales");
            Prueba.Items.Add("Licenciatura en Administración");
            Prueba.Items.Add("Ingeniería Industrial");
            Prueba.Items.Add("Ingeniería Civil");
            Prueba.Items.Add("Licenciatura en Gastronomia");
            Prueba.Items.Add("Ingeniería Mecatrónica");
            Prueba.Items.Add("Licenciatura en Biología");






            
        }

        private void Btnpagina2_Clicked(object sender, EventArgs e)
        {
            var nombre = Prueba.Items[Prueba.SelectedIndex];
            Navigation.PushModalAsync(new Page2(txtusername.Text,txtape.Text,txtdirec.Text,txtphone.Text,nombre,txtsemestre.Text,txtmatricula.Text,txtusuario.Text,txtcorreo.Text,txtgithub.Text));


            
        }

   
        
    }
}
