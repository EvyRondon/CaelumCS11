using Banco.Contas;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Banco
{
    public partial class FormRelatorios : Form
    {
        private List<Conta> contas;

        public FormRelatorios(List<Conta> contas)
        {
            InitializeComponent();
            this.contas = contas;
        }

        private void btnFiltroSaldo_Click(object sender, EventArgs e)
        {
            try
            {
                listaResultado.Items.Clear();
                var resultado = from c in contas
                                where c.Saldo > 5000
                                select c;
                foreach (var c in resultado)
                {
                    listaResultado.Items.Add(c);
                }
                double saldoTotal = resultado.Sum(conta => conta.Saldo);
                double maiorSaldo = resultado.Max(conta => conta.Saldo);

                lblSaldoTotal.Text = saldoTotal.ToString();
                lblMaiorSaldo.Text = maiorSaldo.ToString();
            }
            catch (Exception)
            {
                MessageBox.Show("Não existe contas que se enquadra nesse filtro");
            }
            finally
            {
                lblSaldoTotal.Text = "0";
                lblMaiorSaldo.Text = "0";
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                listaResultado.Items.Clear();
                var resultado = from c in contas
                                where c.Numero < 10 &&
                                c.Saldo > 1000
                                select c;
                foreach (var c in resultado)
                {
                    listaResultado.Items.Add(c);
                }
                double saldoTotal = resultado.Sum(conta => conta.Saldo);
                double maiorSaldo = resultado.Max(conta => conta.Saldo);

                lblSaldoTotal.Text = saldoTotal.ToString();
                lblMaiorSaldo.Text = maiorSaldo.ToString();
            }
            catch (Exception)
            {
                MessageBox.Show("Não existe contas que se enquadra nesse filtro");
            }
        }

        private void FormRelatorios_Load_1(object sender, EventArgs e)
        {
            lblSaldoTotal.Text = "0";
            lblMaiorSaldo.Text = "0";
        }
    }
}
