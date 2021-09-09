using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace ApiRestServidor.Modelos.Domicilio
{
    public class Departamento
    {
        [Key]
        public int IdDepartamento { get; set; }
        
        [Required]
        [StringLength(20)]
        public String Nombre { get; set; }

    }
}
