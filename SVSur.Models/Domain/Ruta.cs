using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SVSur.Models.Domain
{
    [Table("Rutas")]
   public class Ruta
    {
        public int RutaID { get; set; }

        [ForeignKey("Chofer")]
        public int ChoferID { get; set; }

        [Required(ErrorMessage = "El campo Ciudad Origen es obligatorio")]
        [StringLength(100, ErrorMessage = "El campo no puede contener mas de 50 caracteres")]
        public string CiudadOrigen { get; set; }

        [Required(ErrorMessage = "El campo ciudad Destino es obligatorio")]
        [StringLength(100, ErrorMessage = "El campo no puede contener mas de 100 caracteres")]
        public string CiudadDestino { get; set; }

        [Required(ErrorMessage = "El campo Precio es obligatorio")]
        public float Precio { get; set; }

        [Required(ErrorMessage = "El campo Duracion es obligatorio")]
       
        public string Duracion { get; set; }

        [Required(ErrorMessage = "El campo Fecha de viaje es obligatorio")]
        
        public string FechaViaje { get; set; }

        [Required(ErrorMessage = "El campo Hora salida es obligatorio")]
       
        public string HoraSalida { get; set; }

        [Required]
        public bool Estado { get; set; }


        //propiedades de navegacion
        public virtual Chofer Chofer { get; set; }
    }
}
