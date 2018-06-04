using System;
using AppFLOyBUS.control;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppFLOyBUS
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            TraerUsuarios();
        }

        List<Usuario> users = new List<Usuario>();

        public void TraerUsuarios()
        {
            List<Usuario> user = ControlUsuario.OptenerUsuario();
            foreach (Usuario val in user)
            {
                users.Add(val);
                Console.WriteLine(val.nombre);
            }
        }
        public void realizarLogin()
        {
            foreach (Usuario val in users)
            {
                Console.WriteLine(val.nombre);
                if (val.usuario1 == txtUsuario.Text && val.contraseña == txtPass.Text)
                {
                    goto ingreso;
                }
                else
                {
                    goto mostrarmensaje;
                }
            }
        
             mostrarmensaje: {
                 MessageBox.Show("Usuario o contraseña Incorrecta");
             }
             ingreso:
             {
                 Console.WriteLine("Login");
                 ListaPedidos view = new ListaPedidos();
                 view.Show();
                 this.Hide();
             }
        }

        private void btn_ingresar(object sender, EventArgs e)
        {
          validarCampos();
        }

        private void validarCampos()
        {
            if (txtUsuario.Text.Trim() != "" && txtPass.Text.Trim() != "")
            {
                realizarLogin();
            }
            else
            {
                MessageBox.Show("Debe ingresar los campos requeridos");
            }
        }
    }

}
