namespace Paises.Domain.Services.Implementation
{
    using Paises.Common.Dto.EntityContract;
    using Paises.Domain.Services.Contract;
    using Paises.Infraestructure.Repository.Pais; 
    using System.Net.Http;
    using System.Threading.Tasks;

    public class PaisesServicio : IPaisesServicio
    {
        private IRepositorioPaises repositorio;

        public PaisesServicio(IRepositorioPaises repositorio)
        {
            this.repositorio = repositorio;
        }
        public async Task<RespuestaPais> ObtenerPais(string token)
        {
            HttpResponseMessage response = await this.repositorio.ObtenerPaises(token);
            var json = response.Content.ReadAsStringAsync().Result;
            var respuesta = json.Deserialize<RespuestaPais>();           
            return respuesta;
        }

        /*
         
        public async Task<ResponseVerifyLastGeneratedAlert> GeVerifyLastGeneratedAlert(int idAlerta, string token)
        {
            HttpResponseMessage response = await _alertasServices.GetVerifyLastGeneratedAlert(idAlerta, token);

            switch (response.StatusCode)
            {
                case HttpStatusCode.InternalServerError:
                    throw new ApplicationException("Se ha presentado un error en el Backend, con la data: " + idAlerta.ToString());

                case HttpStatusCode.Unauthorized:
                    throw new UnauthorizedAccessException("Ha expirado el Token");

                case HttpStatusCode.OK:
                    var json = response.Content.ReadAsStringAsync().Result;
                    var respustaVerificarUltimaAlertaGenerada = _encriptionServices.DeserializeEntity<ResponseVerifyLastGeneratedAlert>(json);
                    return respustaVerificarUltimaAlertaGenerada;
                default:
                    throw new Exception();
            }
        }
         
         */
    }
}
