using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Text;

namespace GiovannaMenegoliRM75662.ViewModel
{
    public class LoginViewModel: INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;
        protected virtual void NotifyPropertyChanged([CallerMemberName] string propertyName = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        private string usuario;
        public string Usuario
        {
            get { return usuario; }
            set
            {
                if (usuario != value)
                {
                    usuario = value;
                    NotifyPropertyChanged();
                }
            }
        }

        private string senha;
        public string Senha
        {
            get
            {
                return senha;
            }
            set
            {
                if (senha != value)
                {
                    senha = value;
                    NotifyPropertyChanged();
                }
            }
        }
    }
}
