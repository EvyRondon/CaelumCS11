using System;
using System.Windows.Forms;
using Banco.Contas;
using Banco.Busca;
using System.Collections.Generic;

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

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            try
            {
                string titular = txtTitular.Text;
                bool ehDevedor = this.devedores.Contains(titular);
                for (int i = 0; i < 30000; i++)
                {
                    ehDevedor = this.devedores.Contains(titular);
                }
                if (!ehDevedor)
                {
                    ContaCorrente novaConta = new ContaCorrente();
                    novaConta.Titular = new Cliente(txtTitular.Text, "");
                    novaConta.Numero = novaConta.Numero;

                    formPrincipal.AdicionaConta(novaConta);
                }
                else
                {
                    MessageBox.Show("devedor");
                }

            }
            catch (Exception)
            {
                throw;
            }
            finally{
                Close();
            }
        }

        private void FormCadastroConta_Load(object sender, EventArgs e)
        {
            numero.Text = Convert.ToString(Conta.ProximoNumero());
        }
    }
}
