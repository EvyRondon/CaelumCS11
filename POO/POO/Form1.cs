using System;
using System.Collections.Generic;
using System.Windows.Forms;
using Banco.Contas;

namespace Banco
{
    public partial class Form1 : Form
    {
        public List<Conta> contas;
        public int indice;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            contas = new List<Conta>();

            Cliente gui = new Cliente("Guilherme Silveira", "12345678-9");
            ContaPoupanca c1 = new ContaPoupanca();
            c1 = new ContaPoupanca()
            {
                Titular = gui,
                Numero = 1
            };
            c1.Deposita(100);
            AdicionaConta(c1);

            Conta c2 = new ContaCorrente();
            c2 = new ContaCorrente();
            c2.Titular = new Cliente("Roberto", "1234-67");
            c2.Numero = 2;
            AdicionaConta(c2);

            ContaCorrente c3 = new ContaCorrente();
            c3 = new ContaCorrente();
            c3.Titular = new Cliente("Emily S.", "28390-67");
            c3.Numero = 3;
            AdicionaConta(c3);

            txtNumero.Text = Convert.ToString(contas[0].Numero);
            txtTitular.Text = contas[0].Titular.Nome;
            txtSaldo.Text = Convert.ToString(contas[0].Saldo);

            //if(c1.Equals(c2))
            //    MessageBox.Show("iguais");
            //else
            //    MessageBox.Show("diferentes");
        }

        private void btnDepositar_Click(object sender, EventArgs e)
        {
            try
            {
                Conta selecionada = (Conta) comboContas.SelectedItem;
                if (!string.IsNullOrEmpty(txtValor.Text))
                {
                    selecionada.Deposita(Convert.ToDouble(txtValor.Text));
                    txtSaldo.Text = Convert.ToString(selecionada.Saldo);
                }
                else
                    MessageBox.Show("Digite um valor");
            }
            catch (Exception)
            {
                MessageBox.Show("Argumento Inválido");
            }
        }

        private void btnSacar_Click(object sender, EventArgs e)
        {
            try
            {
                Conta selecionada = (Conta) comboContas.SelectedItem;
                txtSaldo.Text = Convert.ToString(selecionada.Saldo);
                MessageBox.Show("Sucesso!");
            }
            catch (SaldoInsuficienteException)
            {
                MessageBox.Show("O valor do saque é maior que possui na conta.");
                throw;
            }
        }

        private void comboContas_SelectedIndexChanged(object sender, EventArgs e)
        {
            indice = comboContas.SelectedIndex;
            Conta selecionada = contas[indice];
            txtNumero.Text = Convert.ToString(selecionada.Numero);
            txtTitular.Text = selecionada.Titular.Nome;
            txtSaldo.Text = Convert.ToString(selecionada.Saldo);
        }

        private void btnTransferir_Click(object sender, EventArgs e)
        {
            indice = comboContas.SelectedIndex;
            int destino = comboTranfere.SelectedIndex;
            Conta selecionada = contas[indice];
            selecionada.Transfere(Convert.ToDouble(txtValor.Text), contas[destino]);
            txtSaldo.Text = Convert.ToString(selecionada.Saldo);
        }

        public void AdicionaConta(Conta conta) {
            contas.Add(conta);
            comboContas.Items.Add(conta);
            comboTranfere.Items.Add(conta);
            //comboContas.DisplayMember = "Numero";
        }

        private void btnNovaConta_Click(object sender, EventArgs e)
        {
            FormCadastroConta formularioCadastro = new FormCadastroConta(this);
            formularioCadastro.ShowDialog();
        }

        private void btnImposto_Click(object sender, EventArgs e)
        {
            ContaCorrente conta = new ContaCorrente();
            conta.Deposita(200.0);

            SeguroDeVida sv = new SeguroDeVida();

            TotalizadorDeTributos totalizador = new TotalizadorDeTributos();
            totalizador.Adiciona(conta);
            MessageBox.Show($"Total: {totalizador.Total}");
            totalizador.Adiciona(sv);
            MessageBox.Show($"Total: {totalizador.Total}");
        }
    }
}
