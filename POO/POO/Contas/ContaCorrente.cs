using System.Windows.Forms;

namespace Banco.Contas
{
    class ContaCorrente : Conta, ITributavel
    {
        public override void Saca(double valor)
        {
            if (Saldo < valor)
            {
                throw new SaldoInsuficienteException();
            }
            Saldo -= (valor + 0.05);

        }

        public override void Deposita(double valor)
        {
             Saldo += (valor - 0.10);
        }

        public double CalculaTributos()
        {
            return Saldo * 0.05;
        }
    }
}
