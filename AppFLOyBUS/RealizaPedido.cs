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
    public partial class RealizarPedido : Form
    {
        public RealizarPedido()
        {
            InitializeComponent();
            LlenarPlantayAdornos();
        }
        List<Planta> plantas = new List<Planta>();
        List<Adorno> adornos = new List<Adorno>();
        Pedido nuevoPedido = new Pedido();
        Planta plantaSelect = new Planta();
        Adorno adorSelect = new Adorno();


        public void LlenarPlantayAdornos()
        {
            plantas = ControlPedido.OptenerPlantas();
            adornos = ControlPedido.OptenerAdornos();

            foreach (Planta val in plantas) {
                selecPlanta.Items.Add(val.nombrePlanta);
            }
            foreach (Adorno val in adornos) {
                selectAdorno.Items.Add(val.nombre);
            }
        }

        private void itemselect(object sender, EventArgs e)
        {
            Console.WriteLine(selecPlanta.Text);
            foreach (Planta val in plantas) {
                if (val.nombrePlanta == selecPlanta.Text) {
                    this.plantaSelect = val;
                    goto guardarValor;
                }
            }
           guardarValor: {
               this.nuevoPedido.Planta = plantaSelect;
           }
        }

        private void adornoSelect(object sender, EventArgs e) {
            Console.WriteLine(selecPlanta.Text);
            foreach (Adorno val in adornos) {
                if (val.nombre == selectAdorno.Text) {
                    this.adorSelect = val;
                    goto guardarValor;
                }
            } 
            guardarValor:  {
                this.nuevoPedido.idAdorno = adorSelect.Id;
            }
        }

        private void btnEnviarPedido_Click(object sender, EventArgs e){
            validarCampos();
        }

        public void validarCampos()  {
            if (selecPlanta.Text != ""
                && selectAdorno.Text != ""
                && valorDisponible.Text != ""
                && dAncho.Text != ""
                && dLargo.Text != "")  {
                if (nombreUsuario.Text != "") {
                    nuevoPedido.cantidadDineroUsuario = int.Parse(valorDisponible.Text);
                    nuevoPedido.cantidadTotal = plantaSelect.valor + adorSelect.precio;
                    nuevoPedido.nombreCliente = nombreUsuario.Text;
                    nuevoPedido.fechaPedido = DateTime.Now;
                    nuevoPedido.dimensionJardin = Double.Parse(dAncho.Text) * Double.Parse(dLargo.Text);
                    nuevoPedido.comentario = comentarios.Text != "" ? comentarios.Text : " ";

                    try {
                        ControlPedido.IngresarNuevoPedido(nuevoPedido);
                        MessageBox.Show("Su pedido fue enviado con éxito");
                        Bienvenida enviarAtras = new Bienvenida();
                        enviarAtras.Show();
                        this.Hide();
                    }
                    catch (InvalidCastException e)
                    {
                        Console.WriteLine(e);
                    }
                }
                else
                {
                    MessageBox.Show("Falta por ultimo tu Nombre para este pedido");
                }
            }
            else
            {
                MessageBox.Show("Faltan algunos campos por completar");
            }
        }


        private void valorDisponible_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!((int)e.KeyChar == 8 ||
               (int)e.KeyChar >= 48 && (int)e.KeyChar <= 59))
            {
                e.Handled = true;
            }
        }

    }
}
