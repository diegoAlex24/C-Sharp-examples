using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace program_2
{
    public partial class FormPrincipal : Form
    {
        public FormPrincipal()
        {
            InitializeComponent();
        }

        private void buttonClick_Click(object sender, EventArgs e)
        {
            /* Propiedades */
            // Estas pueden aplicar a diversos objetos graficos
            // BackColor: Indica el color del fondo
            // BackgroundImage: Agrega una imagen de fondo
            // Enabled: Indica si esta habilitado o no el objeto
            // Font: Tipo y tamaño de letra
            /* MessageBox */
            // Crea un cuadro con mensaje tipo dialog
            MessageBox.Show("Cuadro con mensaje");
        }
    }
}
