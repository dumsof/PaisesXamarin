using System;
using System.Collections.Generic;
using System.Text;

namespace Paises.Common.Dto.EntityContract
{
    public class RespuestaPais : Respuesta
    {
        public IEnumerable<Pais> Paises { get; set; }
    }
}
