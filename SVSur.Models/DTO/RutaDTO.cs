using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
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
        public string Duracion { get; set; }
        public string FechaViaje { get; set; }
        public string HoraSalida { get; set; }
        public string Nombre { get; set; }

    }
}
