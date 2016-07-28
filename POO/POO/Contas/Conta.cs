using System;
using System.Windows.Forms;

namespace Banco.Contas
{
    public abstract class Conta : Object
    {
        private static int totalDeContas;
        public int Numero { get; set; }
        public Cliente Titular { get; set; }
        public double Saldo { get; protected set; }

        public Conta()
        {
            totalDeContas++;
            Numero = totalDeContas;
        }

        public abstract void Deposita(double valor);

        public abstract void Saca(double valor);

        public void Transfere(double valor, Conta destino)
        {
            try
            {
                Saca(valor);
                destino.Deposita(valor);
            }
            catch (SaldoInsuficienteException)
            {
                MessageBox.Show("Saldo Insuficiente");
            }
        }

        public static int ProximoNumero()
        {
            return totalDeContas + 1;
        }

        public override bool Equals(object outro)
        {
            if (!(outro is Conta))
            {
                return false;
            }
            Conta outraConta = (Conta)outro;
            return Numero == outraConta.Numero;
        }

        public override string ToString()
        {
            return $"Titular : {this.Titular.Nome}";
        }
    }
}
