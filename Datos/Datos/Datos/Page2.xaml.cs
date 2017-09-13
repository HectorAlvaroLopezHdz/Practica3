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
        public Page2(string nombre ,string apellidos,string direccion,string telefono,string carrera,string semestre,string matricula,string usuario,string correo,string github)
        {
            InitializeComponent();
            txtusername.Text = nombre;
            txtape.Text = apellidos;
            txtdirec.Text = direccion;
            txtphone.Text = telefono;
            txtcarrera.Text = carrera;
            txtsemestre.Text = semestre;
            txtmatricula.Text = matricula;
            txtusuario.Text = usuario;
            txtcorreo.Text = correo;
            txtgithub.Text = github;
            btnpagina1.Clicked += Btnpagina1_Clicked;
        }

        private void Btnpagina1_Clicked(object sender, EventArgs e)
        {
            Navigation.PushModalAsync(new MainPage());
        }
    }
}