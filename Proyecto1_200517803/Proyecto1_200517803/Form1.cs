using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto1_200517803
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

    

        private void pROYECTOToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string nombre;

            openFileDialog1.ShowDialog();
            Console.WriteLine("INGRESE NOMBRE DEL PROYECTO");
            MessageBox.Show("INGRESE UN NOMBRE");
            //arbolito.Nodes.Add();


        }

        private void sALIRToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void eJECUTARToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            bool resultado = Analizador.Sintactico.analizar(txtEntrada.Text);
            if(resultado)
            {
                MessageBox.Show("LA CADENA ES CORRECTA************");
            }
            else
            {
                MessageBox.Show("LA CADENA ES INCORRECTA");
            }
        }

    }
}
