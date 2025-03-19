using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WF_Subtração
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnClique_Click(object sender, EventArgs e)
        {
            double numero = double.Parse(txtNumero.Text);
            double numero1 = double.Parse(txtNumero2.Text);
            double resultado = numero - numero1;

            MessageBox.Show($"A subtração de {numero} - {numero1} é: {resultado}");
        }
    }
}
