using System;
using System.ComponentModel.DataAnnotations;

namespace ApiRestServidor.Modelos.Domicilio
{
    public class Domicilio
    {

        [Key]
        public int Id { get; set; }
        
        [Required]
        [StringLength(80)]
        public String CorreoAsociado { get; set; }

        [Required]
        [StringLength(30)]
        public String Direccion { get; set; }

        [Required]
        public String NombreDepartamento { get; set; }
        
        [Required]
        public String NombreMunicipio { get; set; }
    }
}
