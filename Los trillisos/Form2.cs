using MaterialSkin.Controls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Los_trillisos
{
    public partial class Form2 : MaterialForm
    {
        public Form2()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.None;
            label1.Font = new Font("Feather Bold", 10, FontStyle.Bold);
            label1.ForeColor = Color.DarkBlue;
            label2.Font = new Font("Feather Bold", 10, FontStyle.Bold);
            label2.ForeColor = Color.DarkBlue;
            label3.Font = new Font("Feather Bold", 10, FontStyle.Bold);
            label3.ForeColor = Color.DarkBlue;
            label4.Font = new Font("Feather Bold", 10, FontStyle.Bold);
            label4.ForeColor = Color.DarkBlue;
            label5.Font = new Font("Feather Bold", 20, FontStyle.Bold);
            label5.ForeColor = Color.DarkBlue;
            label6.Font = new Font("Feather Bold", 10, FontStyle.Bold);
            label6.ForeColor = Color.DarkBlue;
            label7.Font = new Font("Feather Bold", 10, FontStyle.Bold);
            label7.ForeColor = Color.DarkBlue;
            label1.BackColor = Color.Transparent;
            label2.BackColor = Color.Transparent;
            label3.BackColor = Color.Transparent;
            label4.BackColor = Color.Transparent;
            label5.BackColor = Color.Transparent;
            label6.BackColor = Color.Transparent;
            label7.BackColor = Color.Transparent;
            guna2CircleButton1.BackColor = Color.Transparent;
            guna2CircleButton2.BackColor = Color.Transparent;
            guna2CircleButton3.BackColor = Color.Transparent;
            guna2CircleButton4.BackColor = Color.Transparent;
            guna2CircleButton5.BackColor = Color.Transparent;
            guna2Panel1.BackColor = Color.Transparent;
            guna2Panel2.BackColor = Color.Transparent;
            guna2Panel3.BackColor = Color.Transparent;
            guna2Panel4.BackColor = Color.Transparent;
            guna2Panel5.BackColor = Color.Transparent;
            pictureBox1.BackColor = Color.Transparent;
            pictureBox2.BackColor = Color.Transparent;
            pictureBox3.BackColor = Color.Transparent;
            pictureBox4.BackColor = Color.Transparent;
            pictureBox5.BackColor = Color.Transparent;
            

        }

        private void Form2_Load(object sender, EventArgs e)
        {
            int cornerRadius = 20; // Cambia esto según lo redondeado que quieras los bordes

            // Crear un rectángulo que cubra todo el formulario
            GraphicsPath path = new GraphicsPath();
            path.AddArc(new Rectangle(0, 0, cornerRadius, cornerRadius), 180, 90); // Esquina superior izquierda
            path.AddArc(new Rectangle(this.Width - cornerRadius, 0, cornerRadius, cornerRadius), 270, 90); // Esquina superior derecha
            path.AddArc(new Rectangle(this.Width - cornerRadius, this.Height - cornerRadius, cornerRadius, cornerRadius), 0, 90); // Esquina inferior derecha
            path.AddArc(new Rectangle(0, this.Height - cornerRadius, cornerRadius, cornerRadius), 90, 90); // Esquina inferior izquierda
            path.CloseAllFigures();

            // Establecer la región del formulario a la ruta con esquinas redondeadas
            this.Region = new Region(path);
        }

        // Variables para llevar el conteo de cada pizza
        private int countPeperoni = 0;
        private int countPastor = 0;
        private int countEspecial = 0;
        private int countVegetariana = 0;
        private int countHawaiana = 0;

        private void guna2CircleButton5_Click(object sender, EventArgs e)
        {
            countPeperoni++;
            // Actualizar el Label con el nuevo conteo
            UpdateLabel();
        }

        private void guna2CircleButton1_Click(object sender, EventArgs e)
        {
            countPastor++;
            // Actualizar el Label con el nuevo conteo
            UpdateLabel();
        }

        private void guna2CircleButton2_Click(object sender, EventArgs e)
        {
            // Incrementar el contador de Pizza Hawaiana
            countEspecial++;
            // Actualizar el Label con el nuevo conteo
            UpdateLabel();
        }

        private void guna2CircleButton4_Click(object sender, EventArgs e)
        {
            // Incrementar el contador de Pizza Vegetariana
            countVegetariana++;
            // Actualizar el Label con el nuevo conteo
            UpdateLabel();
        }

        private void guna2CircleButton3_Click(object sender, EventArgs e)
        {
            // Incrementar el contador de Pizza Cuatro Quesos
            countHawaiana++;
            // Actualizar el Label con el nuevo conteo
            UpdateLabel();
        }
        // Método para actualizar el Label con los textos y contadores
        private void UpdateLabel()
        {
            label7.Text = "";

            // Actualizar el Label con el conteo de cada pizza
            if (countPeperoni > 0)
                label7.Text += $"Pizza Peperoni x{countPeperoni}\n";

            if (countPastor > 0)
                label7.Text += $"Pizza Pastor x{countPastor}\n";

            if (countEspecial > 0)
                label7.Text += $"Pizza Especial x{countEspecial}\n";

            if (countVegetariana > 0)
                label7.Text += $"Pizza Vegetariana x{countVegetariana}\n";

            if (countHawaiana > 0)
                label7.Text += $"Pizza Hawaiana x{countHawaiana}\n";
        }
    }
}
