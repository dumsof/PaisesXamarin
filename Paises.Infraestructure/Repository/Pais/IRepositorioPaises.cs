namespace Paises.Infraestructure.Repository.Pais
{
    using System.Net.Http;
    using System.Threading.Tasks;

    public interface IRepositorioPaises
    {

       Task<HttpResponseMessage> ObtenerPaises(string token);

    }
}
