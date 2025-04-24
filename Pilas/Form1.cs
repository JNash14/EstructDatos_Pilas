using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pilas
{
    public partial class Form1: Form
    {
        Pila pi = new Pila();
        public Form1()
        {
            InitializeComponent();
        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            try
            {               
                if (int.Parse(txtNuevo.Text) >= 0)
                {
                    if (pi.Buscar(int.Parse(txtNuevo.Text)))
                    {
                        MessageBox.Show("Dato existente");
                        txtNuevo.Clear();
                        txtNuevo.Focus();
                    }
                    else
                    {
                        pi.Ingresar(int.Parse(txtNuevo.Text));
                        txtNuevo.Clear();
                        txtNuevo.Focus();
                    }
                }
                else
                    MessageBox.Show("No se permiten campos negativos");
            }
            catch (Exception) { MessageBox.Show("Campo vacío"); txtNuevo.Focus(); }
                           
        }

        private void btnListar_Click(object sender, EventArgs e)
        {
            lstBox.Items.Clear();
            pi.Listado(lstBox);
            
        }

        private void btnExtraer_Click(object sender, EventArgs e)
        {
            lstBox.Items.Clear();
            pi.Extraer();
            pi.Listado(lstBox);
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            if (pi.Buscar(int.Parse(txtNuevo.Text))) MessageBox.Show("Existe el dato");
            else MessageBox.Show("No existe el dato");          
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            if (pi.Buscar(int.Parse(txtNuevo.Text)))
            {
                pi.Modificar(int.Parse(txtNuevo.Text), int.Parse(txtModifica.Text));
            }
            else
                MessageBox.Show("Dato a modificar no existe");
            
        }

        private void bntExtraerHasta_Click(object sender, EventArgs e)
        {
            pi.ExtraerHasta(int.Parse(txtNuevo.Text));
        }

        private void btnContar_Click(object sender, EventArgs e)
        {
            pi.Contar();
        }

        private void btLimpiar_Click(object sender, EventArgs e)
        {
            pi.limpiar();
        }
    }
}
