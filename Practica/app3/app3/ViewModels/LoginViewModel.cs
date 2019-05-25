using GalaSoft.MvvmLight.Command;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;

namespace app3.ViewModels
{
    class LoginViewModel:BaseViewModel
    {
        #region variables
        String email;
        String password;
        bool isrunning;
        #endregion

        #region propiedades
        public string Email
        {
            get { return this.email; }
            set { SetValue(ref this.email, value); }
        }

        public string Password
        {
            get { return this.password; }
            set { SetValue(ref this.password, value); }
        }

        public bool IsRunning
        {
            get { return this.isrunning; }
            set { SetValue(ref this.isrunning, value); }
        }
        #endregion

        #region commandos

        public ICommand LoginCommand
        {
            get { return new RelayCommand();}
        }
         #endregion
        }
}
