using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ApiRestProyecto.Modelos
{
    public class Usuario
    {
      
        [Required]
        [Display(Name = "Tipo de usuario")]
        public int TipoUsuario { get; set; }

        [Required]
        [Display(Name = "Primer nombre")]
        [StringLength(25)]
        public String PrimerNombre { get; set; }

        [Display(Name = "Segundo nombre")]
        [StringLength(25)]
        public String SegundoNombre { get; set; }

        [Required]
        [Display(Name = "Primer apellido")]
        [StringLength(25)]
        public String PrimerApellido { get; set; }

        [Display(Name = "Segundo apellido")]
        [StringLength(25)]
        public String SegundoApellido { get; set; }

        [Required]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy:MM:dd}", ApplyFormatInEditMode = true)]
        [Display(Name = "Fecha de nacimiento")]
        public DateTime FechaNacimiento { get; set; }

        [Required]
        public int Edad { get; set; }

        [Key]
        [StringLength(80)]
        public String Correo { get; set; }

        [Required]
        [DataType(DataType.Password)]
        public String Contrasena { get; set; }

    }
}
