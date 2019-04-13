namespace Paises.Infraestructure.Repository.ServiceContract
{
    using Paises.Common.Dto.EntityContract;
    using System.Threading.Tasks;

    public interface IApiService
    {
        Task<RespuestaGenericaServicio> GetList<T>(string urlBase, string prefix, string metodo);
    }
}
