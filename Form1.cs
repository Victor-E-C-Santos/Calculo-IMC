using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IMC
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            double peso, altura, imc;
            peso = Convert.ToDouble(txtPeso.Text);

            altura = Convert.ToDouble(txtAltura.Text);

            imc = peso / (altura * altura);
            

            if (imc < 20)
                lblResultado.Text = "Abaixo do peso\n seu IMC:" + Math.Round(imc, 2);
            else
                if (imc > 20 && imc < 25)
                lblResultado.Text = "Peso normal\n seu IMC:" + Math.Round(imc, 2);

            else
                if (imc > 25 && imc < 30)
                lblResultado.Text = "Sobre Peso\n seu IMC:" + Math.Round(imc, 2);

            else
                if (imc > 30 && imc < 40)
                lblResultado.Text = "Obeso\n seu IMC:" + Math.Round(imc, 2);

            else
                lblResultado.Text = "Obeso Mórbito\n seu IMC:" + Math.Round(imc, 2);

            
        }
    }
}
