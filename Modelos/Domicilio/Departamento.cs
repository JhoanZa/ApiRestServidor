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
        [StringLength(40)]
        public string Nombre { get; set; }

    }
}
