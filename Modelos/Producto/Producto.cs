using System;
using System.ComponentModel.DataAnnotations;

namespace ApiRestServidor.Modelos.Producto
{
    public class Producto
    {
        [Key]
        public int IdProducto { get; set; }
        
        [StringLength(80)]
        public String CorreoVendedor { get; set; }

        [StringLength(40)]
        public String  Categoria { get; set; }

        [StringLength(60)]
        public String Nombre { get; set; }

        [StringLength(250)]
        public String Descripcion { get; set; }

        public int CantidadDisponible { get; set; }

        public decimal ValorVenta { get; set; }
    }
}
