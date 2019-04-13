namespace Paises.Common.Dto.EntityContract
{
    using System;
    using System.Collections.Generic;
    using System.Text;

   public class RespuestaGenericaServicio
    {
        public bool EstadoTransaccion { get; set; }

        public string Mensaje { get; set; }

        public object Contenido { get; set; }
    }
}
