using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

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
        public int IdDepartamento { get; set; }
        
        [Required]
        public int IdMunicipio { get; set; }

        //Relaciones

    }
}
