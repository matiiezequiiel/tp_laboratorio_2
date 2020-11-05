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
        Numero nroResultado;

        public FormCalculadora()
        {
            InitializeComponent();
        }
        private void FormCalculadora_Load(object sender, EventArgs e)
        {
            numero1 = new Numero();
            numero2 = new Numero();
            nroResultado = new Numero();
            this.cmbOperador.SelectedIndex = 0;
        }

        private static double Operar(Numero numero1,Numero Numero2,char operador)
        {
            return Calculadora.Operar(numero1, Numero2, operador);
        }

        private void txtNumero1_TextChanged(object sender, EventArgs e)
        {
            numero1.SetNumero = this.txtNumero1.Text;
        }

        private void txtNumero2_TextChanged(object sender, EventArgs e)
        {
            numero2.SetNumero = this.txtNumero2.Text;
        }

        private void btnOperar_Click(object sender, EventArgs e)
        {
            char operador;
            if (char.TryParse(this.cmbOperador.Text, out operador) && !char.IsWhiteSpace(operador))
            {
                this.btnConvertirABinario.Enabled = true;
                this.btnConvertirADecimal.Enabled = true;
                this.lblResultado.Text = Operar(numero1, numero2, operador).ToString();
            }
            else
            {
                MessageBox.Show("Operador vacio o invalido");
            }
            
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            this.btnConvertirABinario.Enabled = true;
            this.btnConvertirADecimal.Enabled = true;
            this.txtNumero1.Clear();
            this.txtNumero2.Clear();
            this.cmbOperador.SelectedIndex = 0;
            this.lblResultado.ResetText();
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();            
        } 

        private void btnConvertirABinario_Click(object sender, EventArgs e)
        {

            if(!string.IsNullOrWhiteSpace(this.lblResultado.Text))
            {
                nroResultado.SetNumero = this.lblResultado.Text;
                this.lblResultado.Text = nroResultado.DecimalBinario(this.lblResultado.Text);
                this.btnConvertirABinario.Enabled = false;
                this.btnConvertirADecimal.Enabled = true;
            }
            else
            {
                this.lblResultado.Text = "No hay resultado calculado.";
            }
            
        }

        private void btnConvertirADecimal_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(this.lblResultado.Text))
            {
                nroResultado.SetNumero = this.lblResultado.Text;
                this.lblResultado.Text = nroResultado.BinarioDecimal(this.lblResultado.Text);
                this.btnConvertirADecimal.Enabled = false;
                this.btnConvertirABinario.Enabled = true;
            }
            else
            {
                this.lblResultado.Text = "No hay resultado calculado.";
            }

        }
    }
}