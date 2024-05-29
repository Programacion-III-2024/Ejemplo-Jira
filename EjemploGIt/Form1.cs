using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EjemploGIt
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private string Hola(string nombre)
        {
            return nombre;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            string nombre = Textbox1.Text;
            if(nombre.Length > 1){
                MessageBox.Show("Pone un nombre posta, ortiva");
		Application.Exit();
	    }
	    	

        }
    }
}
