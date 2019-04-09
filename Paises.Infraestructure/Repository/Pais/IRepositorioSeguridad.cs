namespace Paises.Infraestructure.Repository.Pais
{
    using Paises.Common.Dto.EntityContract;
    using System.Net.Http;

    public interface IRepositorioSeguridad
    {
        HttpResponseMessage Logueo(InformacionUsuario informacionUsuario, string token);
    }
}
