namespace Paises.ViewModels
{
    using Paises.Domain.Services.Contract;
    using Prism.Commands;
    using Prism.Mvvm;
    using Prism.Navigation;
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;

    public class LoginContentPageViewModel : ViewModelBase
    {
        private IPaisesServicio paisesServicio;
        private string password;
        private bool isShow;
        private bool activeButtonLogin;
        public DelegateCommand LoginBotonClick { get; }


        public string Password
        {
            get => password;
            set
            {
                SetProperty(ref password, value);
                ValidateFieldActive();
            }
        }

        public bool IsShow
        {
            get { return isShow; }
            set { SetProperty(ref isShow, value); }
        }
        public bool ActiveButtonLogin
        {
            get => activeButtonLogin;
            set { SetProperty(ref activeButtonLogin, value); }
        }

        public LoginContentPageViewModel(INavigationService navigationService, IPaisesServicio paisesServicio) : base(navigationService)
        {
            this.paisesServicio = paisesServicio;
            LoginBotonClick = new DelegateCommand(async () => await LoginDelegateCommandAsync());
        }

        private Task LoginDelegateCommandAsync()
        {
            string token = @"eyJhbGciOiJIUzI1NiIsInR5cCI6IkpXVCJ9.eyJ1bmlxdWVfbmFtZSI6ImR1bjM1QGhvdG1haWwuY29tIiwibWlWYWxvciI6ImxvIHF1ZSB5byBxdWllcmEiLCJqdGkiOiJkNzViMTFkZi1hZjBjLTRjMjktYTY4Yi03Zjk0ZmNkNGMwMTgiLCJleHAiOjE1NTQ5MDc3NTUsImlzcyI6InlvdXJkb21haW4uY29tIiwiYXVkIjoieW91cmRvbWFpbi5jb20ifQ.tcIqOGc9L6_ot84kHTCAbsfRVbkslZ3iMuZNt4kdpLM";
            var pais =  this.paisesServicio.ObtenerPais(token);

            throw new NotImplementedException();
        }

        private void ValidateFieldActive()
        {
            IsShow = ActiveButtonLogin = !string.IsNullOrEmpty(Password);
        }
    }
}
