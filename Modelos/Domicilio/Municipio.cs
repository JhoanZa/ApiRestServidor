using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace ApiRestServidor.Modelos.Domicilio
{
    public class Municipio
    {
        public int Id { get; set; }

        [Required]
        public int IdDepartamento { get; set; }
        
        [Required]
        [StringLength(50)]
        public String NombreMunicipio { get; set; }
        
    }
}
