using Refit;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace Paises.Infraestructure.Repository.ServiceContract
{
    public interface IPaisApiServices
    {
        [Headers("Content-Type: application/json")]
        [Get("/api/Alerta/VerificarUltimaAlertaGenerada")]
        Task<HttpResponseMessage> ObtenerApiPaises([Header("Authorization")] string authorization);
    }
}
