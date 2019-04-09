namespace Paises.Infraestructure.Repository.Pais
{
    using Paises.Common.Config;
    using Paises.Infraestructure.Repository.ServiceContract;
    using Refit;
    using System;
    using System.Collections.Generic;
    using System.Net.Http;
    using System.Text;
    using System.Threading.Tasks;

    public class RepositorioPaises : IRepositorioPaises
    {

        /// <summary>
        /// metodo que se comunica con el servicoi externo
        /// </summary>
        /// <param name="token"></param>
        /// <returns></returns>
        public Task<HttpResponseMessage> ObtenerPaises(string token)
        {
            //se crea una interfaz IPaisApiServices, para definir el metodo o servicio externo que consumira refit.
            var restService = RestService.For<IPaisApiServices>(GlobalConfig.HttpClienConfig);
            var response = restService.ObtenerPaises(token);
            return response;
        }

    }
}
