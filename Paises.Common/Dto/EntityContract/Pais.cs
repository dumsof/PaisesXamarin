
namespace Paises.Common.Dto.EntityContract
{

    using System.Collections.Generic;

    /// <summary>
    /// Defines the <see cref="Pais" />
    /// </summary>
    public class Pais
    {
        //para que la lista de provincia no se presente en null, para que muestre un arreglo vacio.
        /// <summary>
        /// Initializes a new instance of the <see cref="Pais"/> class.
        /// </summary>
        public Pais()
        {
            Provincias = new List<Provincia>();
        }


        public int Id { get; set; }


        public string Nombre { get; set; }

        /// <summary>
        /// Gets or sets the Provincias
        /// cada pais le corresponde un listado de provincias, para realizar la 
        /// relación con la tabla de provincias.
        /// </summary>
        public List<Provincia> Provincias { set; get; }
    }
}
