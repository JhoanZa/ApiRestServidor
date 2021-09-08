using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ApiRestServidor.Modelos.Domicilio
{
    public class Municipio
    {
        [Key]
        public int IdMunicipio { get; set; }
        
        [Required]
        [StringLength(50)]
        public String Nombre { get; set; }
        
        [Required]
        public int CodigoPostal { get; set; }
        
        [Required]
        public int IdDepartamento { get; set; }

        //Relaciones
        public virtual Departamento Departamento { get; set; }
    }
}
