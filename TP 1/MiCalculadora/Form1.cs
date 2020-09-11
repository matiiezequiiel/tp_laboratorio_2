using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entidades;

namespace MiCalculadora
{
    public partial class FormCalculadora : Form
    {
        Numero numero1;
        Numero numero2;

        public FormCalculadora()
        {
            InitializeComponent();
        }
        private void FormCalculadora_Load(object sender, EventArgs e)
        {
            numero1 = new Numero();
            numero2 = new Numero();
        }

        private void txtNumero1_TextChanged(object sender, EventArgs e)
        {
            numero1.setNumero = this.txtNumero1.Text;
        }

        private void txtNumero2_TextChanged(object sender, EventArgs e)
        {
            numero2.setNumero = this.txtNumero2.Text;
        }

        private void btnOperar_Click(object sender, EventArgs e)
        {
            this.lblResultado.Text= Calculadora.Operar(numero1, numero2, this.cmbOperador.Text).ToString();
            
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            this.txtNumero1.Clear();
            this.txtNumero2.Clear();
            this.cmbOperador.ResetText();
            this.lblResultado.ResetText();
        }
    }
}