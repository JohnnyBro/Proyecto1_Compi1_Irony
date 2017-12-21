using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

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

        private void aBRIRToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog abrir = new OpenFileDialog();
            if(abrir.ShowDialog()==DialogResult.OK)
            {
                System.IO.StreamReader sr = new System.IO.StreamReader(abrir.FileName);
                txtEntrada.Text = sr.ReadToEnd();
                ListaDirectorio(arbolito, "C:\\Users\\JohnnyBravo\\Desktop");
            }
            //ListaDirectorio(arbolito,);
        }

        private void ListaDirectorio(TreeView tree, String path)
        {
            tree.Nodes.Clear();
            var rutaDirectorio = new DirectoryInfo(path);
            tree.Nodes.Add(CrearNodoDirectorio(rutaDirectorio));
        }

        private static TreeNode CrearNodoDirectorio(DirectoryInfo ruta)
        {
            var NodoDirectorio = new TreeNode(ruta.Name);
            //foreach (var directorio in ruta.GetDirectories())
              //  NodoDirectorio.Nodes.Add(CrearNodoDirectorio(directorio));

            foreach (var archivo in ruta.GetDirectories())
                NodoDirectorio.Nodes.Add(new TreeNode(archivo.Name));

            return NodoDirectorio;
        }

        private void aRBOLToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Interprete inte = new Interprete();
            inte.soloArbol(this.txtentrada.Text);
        }

       

    }
}
