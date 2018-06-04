using System;
using AppFLOyBUS.Datos;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppFLOyBUS.control
{
    public class ControlUsuario
    {
        internal static List<Usuario> OptenerUsuario() {

            return AccesoUsuario.ConsultarUsuario();
        }
    }
}
