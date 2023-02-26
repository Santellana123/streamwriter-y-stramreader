using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace streamwriter_y_stramreader
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnBorrar_Click(object sender, EventArgs e)
        {
            txtArchivo.Clear();
            txtArchivo.Focus();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            SaveFileDialog paquito;
            paquito=new SaveFileDialog();
            paquito.Filter = "Nombre del Archivo|+.txt";
           if (paquito.ShowDialog() == DialogResult.OK) 
            {
                StreamWriter escribir;
                escribir=new StreamWriter(paquito.FileName);
                escribir.Write(txtArchivo.Text); escribir.Close();
            }
        }

        private void btnArchivo_Click(object sender, EventArgs e)
        {
            OpenFileDialog lector;
            lector = new OpenFileDialog();
            lector.Filter = "Nombre del Archivo|+.txt";
            if (lector.ShowDialog()==DialogResult.OK) 
            {
                StreamReader abrir;
                abrir = new StreamReader(lector.FileName);
               txtArchivo.Text = abrir.ReadToEnd(); abrir.Close();
            }
        }
    }
}
