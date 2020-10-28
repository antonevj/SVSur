using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SVSur.Models.DTO
{
   public class RutaDTO
    {
        public int RutaID { get; set; }
        public string CiudadOrigen { get; set; }
         public string Ciudaddestino { get; set; }
        public float Precio { get; set; }
        public DateTime Duracion { get; set; }
        public DateTime FechaViaje { get; set; }
        public DateTime HoraSalida { get; set; }
        public string Nombre { get; set; }

    }
}
