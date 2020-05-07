using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace wfaOOGabrielBertti
{
    public partial class frmConta : Form
    {
        public frmConta()
        {
            InitializeComponent();
        }
         Conta mConta = new Conta();
        //Conta_Comum conta_Comum = new Conta_Comum();
       // Conta_Especial conta_Especial = new Conta_Especial();

        private void btnCriar_Click(object sender, EventArgs e)
        {
            if(int.Parse(mksCtaTipo.Text)==1)//conta comum
            {
                mConta.Conta_Nro = int.Parse(txtNConta.Text);
                mConta.Conta_Titular = txtTitular.Text;
                mConta.Conta_tipo = int.Parse(mksCtaTipo.Text);
                mConta.Conta_Limite = 0;
                lblDispoSaque.Text += "Conta Comum" + "\n";
                lblDispoSaque.Text += "Saldo = " + mConta.Conta_Saldo + "\n";
                lblDispoSaque.Text += "Limite = " + mConta.Conta_Limite + "\n";
            }
            else
            {
                mConta.Conta_Nro = int.Parse(txtNConta.Text);
                mConta.Conta_Titular = txtTitular.Text;
                mConta.Conta_tipo = int.Parse(mksCtaTipo.Text);
                mConta.Conta_Limite = double.Parse(txtLimite.Text) ;
                lblDispoSaque.Text += "Conta Comum" + "\n";
                lblDispoSaque.Text += "Saldo = " + mConta.Conta_Saldo + "\n";
                lblDispoSaque.Text += "Limite = " + mConta.Conta_Limite + "\n";
            }
        }

        private void btnDepositar_Click(object sender, EventArgs e)
        {
            if(int.Parse(mksCtaTipo.Text) == 1)
            {

                mConta.Depositar(double.Parse(txtValor.Text));
                lblDispoSaque.Text += "SALDO = " + mConta.Conta_Saldo + "\n";
                lblDispoSaque.Text += "LIMITE = " + mConta.Conta_Limite + "\n";
            }
            else { 
            
                mConta.Depositar(double.Parse(txtValor.Text));
                lblDispoSaque.Text += "SALDO = " + mConta.Conta_Saldo + "\n";
                lblDispoSaque.Text += "LIMITE = " + mConta.Conta_Limite + "\n";
            }
        }

        private void btnSacar_Click(object sender, EventArgs e)
        {
            try
            {
                if (int.Parse(mksCtaTipo.Text) == 1)
                {

                    mConta.Sacar(double.Parse(txtValor.Text));
                    lblDispoSaque.Text += "SALDO = " + mConta.Conta_Saldo + "\n";
                    lblDispoSaque.Text += "LIMITE = " + mConta.Conta_Limite + "\n";
                }
                else
                {

                    mConta.Sacar(double.Parse(txtValor.Text));
                    lblDispoSaque.Text += "SALDO = " + mConta.Conta_Saldo + "\n";
                    lblDispoSaque.Text += "LIMITE = " + mConta.Conta_Limite + "\n";
                }
            }catch(System.ArgumentException erro)
            {
                MessageBox.Show(erro.Message);
            }
        }
    }
}

