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
    using Paises.Common.Dto.EntityContract;

    public class RepositorioPaises : IRepositorioPaises
    {
        private IApiService apiService;
        public RepositorioPaises(IApiService apiService)
        {
            this.apiService = apiService;
        }

        /// <summary>
        /// metodo que se comunica con el servicoi externo
        /// </summary>
        /// <param name="token"></param>
        /// <returns></returns>
        public Task<HttpResponseMessage> ObtenerPaises(string token)
        {
            //se crea una interfaz IPaisApiServices, para definir el metodo o servicio externo que consumira refit.
            //se agrega RefitSettings, esto con el fin de pasar el token para Athoritazion Beares, comprobado prueba concepto.
            //var restService = RestService.For<IPaisApiServices>("http://localhost:63146", new RefitSettings()
            //{
            //    AuthorizationHeaderValueGetter = () => Task.FromResult(token)
            //});
            ///api/Pais/ObtenerPaises
            var respuesta = apiService.GetList<Pais>("http://localhost:63146", @"/api/Pais/", "ObtenerPaises");


            var restService = RestService.For<IPaisApiServices>("http://localhost:63146");
            var response = restService.ObtenerApiPaises();
            return response;
        }

    }
}
