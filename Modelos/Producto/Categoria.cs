using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ApiRestServidor.Modelos.Producto
{
    public class Categoria
    {
        [Key]
        public int IdCategoria { get; set; }

        [StringLength(40)]
        public String Nombre { get; set; }
    }
}
