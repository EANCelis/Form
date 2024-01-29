using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            if (txtApellido.Text == "")
            {
                txtApellido.BackColor = Color.Red;
            }
            else
                txtApellido.BackColor = Color.White;
            if (txtNombre.Text == "")
            {
                txtNombre.BackColor = Color.Red;
            }
            else
                txtNombre.BackColor = Color.White;
            if (txtEdad.Text == "")
            {
                txtEdad.BackColor = Color.Red;
            }
            else
                txtEdad.BackColor = Color.White;
            if (txtDireccion.Text == "")
            {
                txtDireccion.BackColor = Color.Red;
            }
            else
                txtDireccion.BackColor = Color.White;
            if (txtApellido.Text != "" && txtNombre.Text != "" && txtEdad.Text != "" && txtDireccion.Text != "")
            {
                txtResultado.Text = "Apellido y Nombre: " + txtApellido.Text + " " + txtNombre.Text + " \r\nEdad: " + txtEdad.Text + "\r\nDireccion: " + txtDireccion.Text;
            }
        }

        private void txtEdad_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar < 48 || e.KeyChar > 59) && e.KeyChar != 8)
                e.Handled = true;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        
    }
}
