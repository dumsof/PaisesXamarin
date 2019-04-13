using Prism;
using Prism.Ioc;
using Paises.ViewModels;
using Paises.Views;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using Paises.Domain.Services.Contract;
using Paises.Domain.Services.Implementation;
using Paises.Infraestructure.Repository.Pais;
using Paises.Infraestructure.Repository.ServiceContract;

[assembly: XamlCompilation(XamlCompilationOptions.Compile)]
namespace Paises
{
    public partial class App
    {
        /* 
         * The Xamarin Forms XAML Previewer in Visual Studio uses System.Activator.CreateInstance.
         * This imposes a limitation in which the App class must have a default constructor. 
         * App(IPlatformInitializer initializer = null) cannot be handled by the Activator.
         */
        public App() : this(null) { }

        public App(IPlatformInitializer initializer) : base(initializer) { }

        protected override async void OnInitialized()
        {
            InitializeComponent();

            await NavigationService.NavigateAsync("NavigationPage/Login");
        }

        protected override void RegisterTypes(IContainerRegistry containerRegistry)
        {
            containerRegistry.RegisterForNavigation<NavigationPage>();
            containerRegistry.RegisterForNavigation<MainPage, MainPageViewModel>();
            containerRegistry.RegisterForNavigation<LoginContentPage, LoginContentPageViewModel>("Login");

            //Inyeccion de servicios.
            containerRegistry.RegisterSingleton<IRepositorioPaises, RepositorioPaises>();
            containerRegistry.RegisterSingleton<IPaisesServicio, PaisesServicio>();
            containerRegistry.RegisterSingleton<IApiService, ApiService>();
        }
    }
}
