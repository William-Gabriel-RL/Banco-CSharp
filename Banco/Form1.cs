using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using Banco.Contas;

namespace Banco
{
    public partial class Form1 : Form
    {
        private Dictionary<string, Conta> dicionario;
        public Form1()
        {
            InitializeComponent();
        }
        private List<Conta> contas;
        public void AdicionaConta(Conta conta)
        {
            this.contas.Add(conta);
            comboContas.Items.Add(conta);
            comboDestinoTransferencia.Items.Add(conta);
            this.dicionario.Add(conta.Titular.Nome, conta);
        }

        private void Form1_Load_1(object sender, EventArgs e)
        {
            this.contas = new List<Conta>();
            this.dicionario = new Dictionary<string, Conta>();

            Conta c2 = new ContaPoupanca
            {
                Titular = new Cliente("Ingrid"),
                Numero = 2
            };
            this.AdicionaConta(c2);

            Conta c3 = new ContaCorrente
            {
                Titular = new Cliente("Aurora"),
                Numero = 3
            };
            this.AdicionaConta(c3);

        }

        private void botaoSaque_Click(object sender, EventArgs e)
        {
            Conta selecionada = (Conta)comboContas.SelectedItem;
            double valor = Convert.ToDouble(textoValor.Text);
            try
            {
                selecionada.Saca(valor);
                textoSaldo.Text = Convert.ToString(selecionada.Saldo);
                MessageBox.Show("Sucesso");
            }
            catch (SaldoInsuficienteException)
            {
                MessageBox.Show("Saldo Insuficiente");
            }

        }

        private void Depositar_Click(object sender, EventArgs e)
        {
            Conta selecionada = (Conta)comboContas.SelectedItem;
            double valor = Convert.ToDouble(textoValor.Text);
            try
            {
                selecionada.Deposita(valor);
                textoSaldo.Text = Convert.ToString(selecionada.Saldo);
                MessageBox.Show("Sucesso");
            }
            catch (ArgumentException)
            {
                MessageBox.Show("Argumento Inválido!");
            }

        }



        private void comboContas_SelectedIndexChanged(object sender, EventArgs e)
        {
            int indice = comboContas.SelectedIndex;
            Conta selecionada = contas[indice];
            textoNumero.Text = Convert.ToString(selecionada.Numero);
            textoTitular.Text = selecionada.Titular.Nome;
            textoSaldo.Text = Convert.ToString(selecionada.Saldo);
        }

        private void botaoTransferir_Click(object sender, EventArgs e)
        {
            int indiceOrigem = comboContas.SelectedIndex;
            int indiceDestino = comboDestinoTransferencia.SelectedIndex;
            double valor = Convert.ToDouble(textoValor.Text);
            Conta origem = contas[indiceOrigem];
            Conta destino = contas[indiceDestino];
            origem.Transfere(valor, destino);
            textoSaldo.Text = Convert.ToString(origem.Saldo);
            MessageBox.Show("Sucesso");
        }

        private void botaoNovaConta_Click(object sender, EventArgs e)
        {
            FormCadastroConta formularioDeCadastro = new FormCadastroConta(this);
            formularioDeCadastro.ShowDialog();
        }

        private void botaoTributos_Click(object sender, EventArgs e)
        {
            FormCalculaImposto formularioDeImposto = new FormCalculaImposto();
            formularioDeImposto.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                string nomeTitular = buscaTitular.Text;
                Conta conta = dicionario[nomeTitular];
                textoTitular.Text = conta.Titular.Nome;
                textoNumero.Text = Convert.ToString(conta.Numero);
                textoSaldo.Text = Convert.ToString(conta.Saldo);
                comboContas.SelectedItem = conta;
            }
            catch (Exception)
            {
                MessageBox.Show("Titular inexistente");
            }
        }

        private void botaoRelatorio_Click(object sender, EventArgs e)
        {
            FormRelatorios form = new FormRelatorios(this.contas);
            form.ShowDialog();
        }
    }

    public class Cliente
    {
        public Cliente(string nome)
        {
            this.Nome = nome;
        }

        public string Nome { get; set; }

    }
}
