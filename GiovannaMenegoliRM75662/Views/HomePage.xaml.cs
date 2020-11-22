using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace GiovannaMenegoliRM75662.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class HomePage : ContentView
    {
        public HomePage()
        {
            InitializeComponent();
        }

        private void Usuario_Clicked(object sender, EventArgs e)
        {
            MessagingCenter.Send<LoginPage>(new LoginPage(), "UsuarioPageAbrir");

        }

        private void Funcionario_Clicked(object sender, EventArgs e)
        {
            MessagingCenter.Send<LoginPage>(new LoginPage(), "LoginPageAbrir");
        }
    }
}