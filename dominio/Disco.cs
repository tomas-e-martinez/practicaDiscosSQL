using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dominio
{
    public class Disco
    {
        public int Id { get; set; }

        [DisplayName("Título")]
        public string Titulo { get; set; }

        [DisplayName("Fecha de lanzamiento")]
        public DateTime FechaLanzamiento { get; set; }

        [DisplayName("Cant. de canciones")]
        public int CantidadCanciones { get; set; }
        public string UrlImagenTapa { get; set; }

        [DisplayName("Formato")]
        public TipoEdicion TipoEdicion { get; set; }
        public Estilo Estilo { get; set; }
    }
}
