using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SVSur.Models.Domain
{
    [Table("Choferes")]
    public  class Chofer
    {

        public int ChoferID { get; set; }

        [ForeignKey("Bus")]
        public int BusID { get; set; }

        [Required(ErrorMessage = "El campo Nombres es obligatorio")]
        [StringLength(50, ErrorMessage = "El campo no puede contener mas de 50 caracteres")]
        public string Nombre { get; set; }

        [Required(ErrorMessage = "El campo Apellidos es obligatorio")]
        [StringLength(100, ErrorMessage = "El campo no puede contener mas de 100 caracteres")]
        public string Apellidos { get; set; }

        [Required(ErrorMessage = "El campo Sexo es obligatorio")]
        [StringLength(20, ErrorMessage = "El campo no puede contener mas de 20 caracteres")]
        public string Sexo { get; set; }

        [Required(ErrorMessage = "El campo Edad es obligatorio")]
        public int Edad { get; set; }

        [Required(ErrorMessage = "El campo DNI es obligatorio")]
        public int DNI { get; set; }


        [Required]
        public bool Estado { get; set; }


        //propiedades de navegacion
        public virtual Bus Bus { get; set; }

    }
}
