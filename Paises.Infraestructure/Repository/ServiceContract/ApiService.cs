namespace Paises.Infraestructure.Repository.ServiceContract
{
    using Newtonsoft.Json;
    using Paises.Common.Dto.EntityContract;
    using System;
    using System.Collections.Generic;
    using System.Net.Http;
    using System.Threading.Tasks;

    public class ApiService : IApiService
    {
        public async Task<RespuestaGenericaServicio> GetList<T>(string urlBase, string prefix, string metodo)
        {
            try
            {
                var httpClient = new HttpClient();
                httpClient.BaseAddress = new Uri(urlBase);
                var response = await httpClient.GetAsync($"{prefix}{metodo}");
                var respuestaJson = await response.Content.ReadAsStringAsync();
                if (!response.IsSuccessStatusCode)
                {
                    return new RespuestaGenericaServicio
                    {
                        EstadoTransaccion = false,
                        Mensaje = respuestaJson,
                    };
                }
                var listGenerict = JsonConvert.DeserializeObject<List<T>>(respuestaJson);
                return new RespuestaGenericaServicio
                {
                    EstadoTransaccion = true,
                    Contenido = listGenerict
                };

            }
            catch (Exception exeption)
            {
                return new RespuestaGenericaServicio
                {
                    EstadoTransaccion = false,
                    Mensaje = exeption.Message,
                };
            }
        }
    }
}
