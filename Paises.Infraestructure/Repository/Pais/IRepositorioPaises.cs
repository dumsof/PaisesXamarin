using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;

namespace Paises.Infraestructure.Repository.Pais
{
    public interface IRepositorioPaises
    {

        HttpResponseMessage ObtenerPaises(string token);

    }
}
