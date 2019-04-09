namespace Paises.Infraestructure.Repository.Pais
{
    using Paises.Common.Config;
    using Paises.Common.Dto.EntityContract;
    using Paises.Infraestructure.Repository.ServiceContract;
    using Refit;
    using System.Net.Http;

    public class RepositorioSeguridad : IRepositorioSeguridad
    {
        public HttpResponseMessage Logueo(InformacionUsuario informacionUsuario, string token)
        {
            //se crea una interfaz IPaisApiServices, para definir el metodo o servicio externo que consumira refit.
            var restService = RestService.For<ISeguridadApiServices>(GlobalConfig.HttpClienConfig);
            var response = restService.LogueoApi(informacionUsuario, token);
            return response.Result;
        }
    }
}
