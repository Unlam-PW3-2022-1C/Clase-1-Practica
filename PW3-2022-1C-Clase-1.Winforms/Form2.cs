using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PW3_2022_1C_Clase_1.Winforms
{
    public partial class Form2 : Form
    {
        string[] valores = { "Si", 
                            "Re Si",
                            "No entendí", 
                            "Vuelve a hacer tu pregunta",
                            "Lo veo mal", "No hay posibilidades",
                            "Tal vez", "Posiblemente", 
                            "No" };

        public Form2()
        {
            InitializeComponent();
            
        }

        private void Form2_Load(object sender, EventArgs e)

        {
            Random random = new Random();
            int ran = random.Next(valores.Length);
            Respuesta.Text = this.valores[ran];

            
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnRegresar_Click(object sender, EventArgs e)
        {
            Close();
            form1 form = new form1();
            form.Show();
        }
    }
}
