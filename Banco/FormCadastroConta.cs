using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Banco.Busca;
using Banco.Contas;

namespace Banco
{
    public partial class FormCadastroConta : Form
    {
        private ICollection<string> devedores;
        private Form1 formPrincipal;
        public FormCadastroConta(Form1 formPrincipal)
        {
            this.formPrincipal = formPrincipal;
            InitializeComponent();

            GeradorDeDevedores gerador = new GeradorDeDevedores();
            this.devedores = gerador.GeraList();
        }
        public FormCadastroConta()
        {
            InitializeComponent();
        }

        private void FormCadastroConta_Load(object sender, EventArgs e)
        {
            comboTipoConta.Items.AddRange(new string[] { "Conta Corrente", "Conta Poupança" });
            textoNumero.Text = Convert.ToString(Conta.ProximoNumero());
        }

        private void botaoCadastro_Click(object sender, EventArgs e)
        {
            string titular = textoTitular.Text;
            bool ehDevedor = this.devedores.Contains(titular);
            if (!ehDevedor)
            {
                Conta novaConta = new ContaCorrente();
                novaConta.Titular = new Cliente(textoTitular.Text);
                this.formPrincipal.AdicionaConta(novaConta);
            }
            else
            {
                MessageBox.Show("Devedor!");
            }

        }

        private void textoNumero_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
