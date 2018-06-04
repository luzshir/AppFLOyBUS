using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppFLOyBUS.Datos
{
    class AccesoUsuario
    {
        private static bdJardineriaEntities context = new bdJardineriaEntities();

        internal static List<Usuario> ConsultarUsuario()
        {
            return context.Usuario.ToList();
        }
    }
}
