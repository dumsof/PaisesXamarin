using Paises.Common.Dto.EntityContract;
using Refit;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace Paises.Infraestructure.Repository.ServiceContract
{
    public interface ISeguridadApiServices
    {
        [Headers("Content-Type: application/json")]
        [Get("/api/Alerta/VerificarUltimaAlertaGenerada")]
        Task<HttpResponseMessage> LogueoApi(InformacionUsuario informacionUsuario, [Header("Authorization")] string authorization);
    }
}
