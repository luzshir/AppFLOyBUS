//------------------------------------------------------------------------------
// <auto-generated>
//    Este código se generó a partir de una plantilla.
//
//    Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//    Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace AppFLOyBUS
{
    using System;
    using System.Collections.Generic;
    
    public partial class Pedido
    {
        public int Id { get; set; }
        public string nombreCliente { get; set; }
        public System.DateTime fechaPedido { get; set; }
        public int cantidadTotal { get; set; }
        public double dimensionJardin { get; set; }
        public int cantidadDineroUsuario { get; set; }
        public string comentario { get; set; }
        public int idPlanta { get; set; }
        public int idAdorno { get; set; }
    
        public virtual Adorno Adorno { get; set; }
        public virtual Planta Planta { get; set; }
    }
}
