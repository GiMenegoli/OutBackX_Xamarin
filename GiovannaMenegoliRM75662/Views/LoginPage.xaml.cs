using GiovannaMenegoliRM75662.ViewModel;
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
    public partial class LoginPage : ContentView
    {
        protected LoginViewModel loginViewModel;
        public LoginPage()
        {
            InitializeComponent();
            loginViewModel = new LoginViewModel();
            BindingContext = loginViewModel;
        }
        private void BotaoEntrarClicked(object o, EventArgs e)
        {
            var mensagem = loginViewModel.Usuario + " - " + loginViewModel.Senha;
            DisplayAlert("Dados ViewModel", mensagem, "Fechar");
            MessagingCenter.Send<LoginPage>(this, "LoginSucesso");
        }

        private void DisplayAlert(string v1, string mensagem, string v2)
        {
            throw new NotImplementedException();
        }

       
    }
}