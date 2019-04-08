namespace Paises.Common.Dto.EntityContract
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    public class Provincia
    {
        public int Id { get; set; }

        public string Nombre { get; set; }

        public int PaisId { set; get; }

        public Pais Pais { set; get; }
    }
}
