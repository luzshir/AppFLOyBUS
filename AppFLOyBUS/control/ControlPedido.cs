using System;
using AppFLOyBUS.Datos;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppFLOyBUS.control
{
    class ControlPedido
    {
        public static void IngresarNuevoPedido(Pedido pedido)
        {
            AccesoPedido.IngresarPedido(pedido);
        }

        internal static List<Planta> OptenerPlantas()
        {
            return AccesoPedido.ConsultarPlantas();
        }
        internal static List<Adorno> OptenerAdornos() 
        {
            return AccesoPedido.ConsultarAdornos();
        }
    }
}
