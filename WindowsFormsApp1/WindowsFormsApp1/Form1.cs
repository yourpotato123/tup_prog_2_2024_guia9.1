using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        FiscalizadorVTV fisca = new FiscalizadorVTV();


        public Form1()
        {
            InitializeComponent();
        }

        private void btIniciar_Click(object sender, EventArgs e)
        {
            int dni = Convert.ToInt32(tbDni.Text);
            string nombre = tbNombre.Text;
            string correo = tbCorreo.Text;
            
            if ()
                Propietario dueño = new Propietario(dni, nombre, correo);
            fisca.AgregarPatente(dni, nombre, correo);
        }

        private void btVer_Click(object sender, EventArgs e)
        {

        }
    }
}
