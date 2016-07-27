using System;
using System.Windows.Forms;

namespace POO
{
    public partial class FormCadastroConta : Form
    {
        private Form1 formPrincipal;

        public FormCadastroConta(Form1 formPrincipal)
        {
            this.formPrincipal = formPrincipal;
            InitializeComponent();
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            ContaCorrente novaConta = new ContaCorrente();
            novaConta.Titular = new Cliente(txtTitular.Text, "");
            novaConta.Numero = Convert.ToInt32(txtNumero.Text);

            this.formPrincipal.AdicionaConta(novaConta);
        }

        private void FormCadastroConta_Load(object sender, EventArgs e)
        {
        }
    }
}
