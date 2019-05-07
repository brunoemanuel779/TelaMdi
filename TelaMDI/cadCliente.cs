using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace TelaMDI
{
    public partial class frmCliente : Form
    {
        public frmCliente()
        {
            InitializeComponent();
        }

        private void habilitar()
        {
            txtCodigo.Enabled = false;
            txtNome.Enabled = true;
            mskCpf.Enabled = true;
            mskDtNasc.Enabled = true;
        }

        private void desHabilitar()
        {
            txtCodigo.Enabled = false;
            txtNome.Enabled = false;
            mskCpf.Enabled = false;
            mskDtNasc.Enabled = false;
        }

        private void limparControle()
        {
            txtCodigo.Clear();
            txtNome.Clear();
            mskDtNasc.Clear();
            mskCpf.Clear();
            mskCpf.Focus();
        }

        private bool validaDados()
        {
            if (string.IsNullOrEmpty(mskCpf.Text))
            {
                MessageBox.Show("Prenchimento de campo CPF obrigatorio", "ACR Rental Car",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
                mskCpf.Clear();
                mskCpf.Focus();
            }

            DateTime auxData;
            if (!(DateTime.TryParse(mskDtNasc.Text,out auxData)))
            {
                MessageBox.Show("Prenchimento de campo Data de nascimento obrigatorio", "ACR Rental Car",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
                mskDtNasc.Clear();
                mskDtNasc.Focus();
                return false;
            }
            if (string.IsNullOrEmpty(txtNome.Text) || string.IsNullOrWhiteSpace(txtNome.Text))
            {
                MessageBox.Show("Prenchimento de campo Nome obrigatorio", "ACR Rental Car",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtNome.Clear();
                txtNome.Focus();
                return false;
            }
            return true;
        }

        private void lblDtNasc_Click(object sender, EventArgs e)
        {

        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnIncluir_Click(object sender, EventArgs e)
        {
            if (validaDados() == false)
                return;
        }
    }
}
