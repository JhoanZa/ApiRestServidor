using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ApiRestServidor.Modelos.Domicilio
{
    public class Departamento
    {
        [Key]
        public int IdDepartamento { get; set; }
        
        [Required]
        [StringLength(30)]
        public String Nombre { get; set; }

        //Relaciones
        public virtual ICollection<Municipio> Municipios { get; set; }

    }
}
