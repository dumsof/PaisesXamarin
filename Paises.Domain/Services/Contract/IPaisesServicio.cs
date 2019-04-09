namespace Paises.Domain.Services.Contract
{
    using Paises.Common.Dto.EntityContract;
    using System.Collections.Generic;
    using System.Threading.Tasks;

    public interface IPaisesServicio
    {
        Task<Pais> ObtenerPais(string token);
    }
}
