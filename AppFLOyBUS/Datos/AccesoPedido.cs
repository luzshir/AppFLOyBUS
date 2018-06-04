using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppFLOyBUS.Datos
{
    class AccesoPedido
    {
        private static bdJardineriaEntities context = new bdJardineriaEntities();

        internal static List<Planta> ConsultarPlantas()
        {
            return context.Planta.ToList();
        }

        internal static List<Adorno> ConsultarAdornos()
        {
            return context.Adorno.ToList();
        }

        public static void IngresarPedido(Pedido pedido)
        {
            context.Pedido.Add(pedido);
            context.SaveChanges();
        }
    }
}
