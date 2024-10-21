using MaterialSkin.Controls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MaterialSkin;
using MaterialSkin.Controls;

namespace Los_trillisos
{
    public partial class Proveedor : MaterialForm
    {
        public Proveedor()
        {
            InitializeComponent();

            comboBoxProductos.Items.Add("SELECCIONAR");
            comboBoxProductos.Items.Add("Caja de pizza");
            comboBoxProductos.Items.Add("Piña");
            comboBoxProductos.Items.Add("Harina");

            comboBoxProductos.SelectedIndex = 0;
        }

        private void buttonConfirmar_Click(object sender, EventArgs e)
        {
           
            if (comboBoxProductos.SelectedItem.ToString() == "SELECCIONAR")
            {
                MessageBox.Show("Por favor, selecciona un producto válido.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                string productoSeleccionado = comboBoxProductos.SelectedItem.ToString();

                DialogResult resultado = MessageBox.Show($"¿Estás seguro de que deseas aceptar el producto: {productoSeleccionado}?",
                                                         "Confirmar Producto",
                                                         MessageBoxButtons.YesNo,
                                                         MessageBoxIcon.Question);

                if (resultado == DialogResult.Yes) 
                {
                    MessageBox.Show($"Has aceptado el producto: {productoSeleccionado}.",
                                    "Producto Aceptado",
                                    MessageBoxButtons.OK,
                                    MessageBoxIcon.Information);
                }
            }
        }
    }
}
