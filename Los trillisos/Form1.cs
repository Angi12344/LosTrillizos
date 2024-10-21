using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.UI.WebControls.WebParts;
using System.Windows.Forms;
using Guna.UI2.WinForms;
using MaterialSkin;
using MaterialSkin.Controls;

namespace Los_trillisos
{
    public partial class Form1 : MaterialForm
    {
        public Form1()
        {
            InitializeComponent();
            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.ColorScheme = new ColorScheme(
            Primary.Yellow500,   // Color primario
            Primary.Yellow500,   // Color primario más oscuro
            Primary.Yellow500,   // Color primario más claro
            Accent.Yellow400,         // Color blanco como acento
            TextShade.WHITE      // Sombra de texto blanca
        );
            tabPage1.BackColor = Color.WhiteSmoke;
            label1.Font = new Font("Feather Bold", 24, FontStyle.Bold);
            label1.ForeColor = Color.DarkBlue;
            label2.Font = new Font("Feather Bold", 24, FontStyle.Bold);
            label2.ForeColor = Color.DarkBlue;
            label3.Font = new Font("Feather Bold", 14, FontStyle.Bold);
            label3.ForeColor = Color.DarkBlue;
            label4.Font = new Font("Feather Bold", 14, FontStyle.Bold);
            label4.ForeColor = Color.DarkBlue;
            label5.Font = new Font("Feather Bold", 10, FontStyle.Bold);
            label5.ForeColor = Color.DarkBlue;
            label5.BackColor = Color.WhiteSmoke;
            label6.Font = new Font("Feather Bold", 10, FontStyle.Bold);
            label6.ForeColor = Color.DarkBlue;
            label6.BackColor = Color.WhiteSmoke;
            label7.Font = new Font("Feather Bold", 14, FontStyle.Bold);
            label7.ForeColor = Color.DarkBlue;
            label8.Font = new Font("Feather Bold", 14, FontStyle.Bold);
            label8.ForeColor = Color.DarkBlue;
            label9.Font = new Font("Feather Bold", 10, FontStyle.Bold);
            label9.ForeColor = Color.DarkBlue;
            label10.Font = new Font("Feather Bold", 10, FontStyle.Bold);
            label10.ForeColor = Color.DarkBlue;
            label11.Font = new Font("Feather Bold", 10, FontStyle.Bold);
            label11.ForeColor = Color.DarkBlue;
            label12.Font = new Font("Feather Bold", 10, FontStyle.Bold);
            label12.ForeColor = Color.DarkBlue;
            label13.Font = new Font("Feather Bold", 10, FontStyle.Bold);
            label13.ForeColor = Color.DarkBlue;
            label14.Font = new Font("Feather Bold", 10, FontStyle.Bold);
            label14.ForeColor = Color.DarkBlue;
            label15.Font = new Font("Feather Bold", 10, FontStyle.Bold);
            label15.ForeColor = Color.White;
            label16.Font = new Font("Feather Bold", 14, FontStyle.Bold);
            label16.ForeColor = Color.DarkBlue;
            guna2Button1.Font = new Font("Feather Bold", 10, FontStyle.Bold);
            guna2Button1.ForeColor = Color.DarkBlue;
            guna2Button2.Font = new Font("Feather Bold", 10, FontStyle.Bold);
            guna2Button2.ForeColor = Color.DarkBlue;
            guna2Button3.Font = new Font("Feather Bold", 10, FontStyle.Bold);
            guna2Button3.ForeColor = Color.DarkBlue;
            guna2Button5.Font = new Font("Feather Bold", 10, FontStyle.Bold);
            guna2Button5.ForeColor = Color.White;
            guna2CircleButton1.BackColor = Color.WhiteSmoke;
            guna2CircleButton2.BackColor = Color.WhiteSmoke;
            guna2CircleButton3.BackColor = Color.Transparent;
            guna2CircleButton4.BackColor = Color.Transparent;
            guna2CircleButton5.BackColor = Color.Transparent;
            pictureBox1.BackColor = Color.Transparent;
            pictureBox2.BackColor = Color.Transparent;
            pictureBox3.BackColor = Color.Transparent;
            label1.BackColor = Color.Transparent;
            label2.BackColor = Color.Transparent;
            label3.BackColor = Color.Transparent;
            label4.BackColor = Color.Transparent;
            label5.BackColor = Color.Transparent;
            label6.BackColor = Color.Transparent;
            label7.BackColor = Color.Transparent;
            label8.BackColor = Color.Transparent;
            label9.BackColor = Color.Transparent;
            label10.BackColor = Color.Transparent;
            label11.BackColor = Color.Transparent;
            label12.BackColor = Color.Transparent;
            label13.BackColor = Color.Transparent;
            label14.BackColor = Color.Transparent;
            label15.BackColor = Color.Transparent;
            label16.BackColor = Color.Transparent;
            guna2Button1.BackColor = Color.Transparent;
            guna2Button2.BackColor = Color.Transparent;
            guna2Button3.BackColor = Color.Transparent;
            guna2Button4.BackColor = Color.Transparent;
            guna2Button5.BackColor = Color.Transparent;
            guna2Panel1.BackColor = Color.Transparent;
            guna2Panel2.BackColor = Color.Transparent;
            guna2Panel3.BackColor = Color.Transparent;
            guna2Panel4.BackColor = Color.Transparent;
            guna2Panel5.BackColor = Color.Transparent;
            guna2Panel6.BackColor = Color.Transparent;
            guna2Panel7.BackColor = Color.Transparent;
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {

            Form2 form2 = new Form2();

            // Mostrar el nuevo formulario
            form2.Show();
        }
    }
}
