namespace Paises.ViewModels
{
    using Paises.Domain.Services.Contract;
    using Prism.Commands;
    using Prism.Mvvm;
    using Prism.Navigation;
    using System;
    using System.Collections.Generic;
    using System.Diagnostics;
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
            string token = @"eyJhbGciOiJIUzI1NiIsInR5cCI6IkpXVCJ9.eyJ1bmlxdWVfbmFtZSI6ImR1bkBob3RtYWlsLmNvbSIsIm1pVmFsb3IiOiJsbyBxdWUgeW8gcXVpZXJhIiwianRpIjoiY2Q1MDIzOTctNTRkNi00OWIyLWI1ZmItMzM1ZTdjYzI4YjlhIiwiZXhwIjoxNTU1MDMxNTk3LCJpc3MiOiJ5b3VyZG9tYWluLmNvbSIsImF1ZCI6InlvdXJkb21haW4uY29tIn0.XUbNmdgYa6MXR5Ks6gGLgA03lVXwY4Di2zFw4YEtmUQ";
            var pais =  this.paisesServicio.ObtenerPais(token);
            Debug.WriteLine(pais);

            throw new NotImplementedException();
        }

        private void ValidateFieldActive()
        {
            IsShow = ActiveButtonLogin = !string.IsNullOrEmpty(Password);
        }
    }
}
