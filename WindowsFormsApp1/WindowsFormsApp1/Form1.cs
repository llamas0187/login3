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
        public Form1()
        {
            InitializeComponent();
        }

        private void Aceptar_Click(object sender, EventArgs e)
        {
            if (Textusuario.Text == "Juancho")
            {
                if (Textcontra.Text == "123tamarindo")
                    MessageBox.Show("felicidades, su cuenta de Pornhub ha iniciado");
                else
                    MessageBox.Show("Su contraseña es incorrecta, cochino lo cache");
            }
            else
                MessageBox.Show("El nombre de usuario es incorrecto");
        }
        private void Salir_Click_1(object sender, EventArgs e)
        {

        }
    }
    }

