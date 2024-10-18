using MaterialSkin;
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
    public partial class Iniciar_sesion : MaterialForm
    {
        public Iniciar_sesion()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.None;
            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.ColorScheme = new ColorScheme(
            Primary.Yellow500,   // Color primario
            Primary.Yellow500,   // Color primario más oscuro
            Primary.Yellow500,   // Color primario más claro
            Accent.Yellow400,         // Color blanco como acento
            TextShade.WHITE      // Sombra de texto blanca
        );
            label1.Font = new Font("Feather Bold", 26, FontStyle.Bold);
            label1.ForeColor = Color.White;
            label1.BackColor = Color.Transparent;
            guna2TextBox1.BackColor = Color.Transparent;
            guna2TextBox1.Font = new Font("Feather Bold", 10, FontStyle.Bold);
            guna2TextBox2.BackColor = Color.Transparent;
            guna2TextBox2.Font = new Font("Feather Bold", 10, FontStyle.Bold);
            guna2Button1.BackColor = Color.Transparent;
            guna2Button1.Font = new Font("Feather Bold", 10, FontStyle.Bold);
        }

        private void Iniciar_sesion_Load(object sender, EventArgs e)
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
    }
}
