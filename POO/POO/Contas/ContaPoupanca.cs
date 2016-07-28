using System;

namespace Banco.Contas
{
    class ContaPoupanca : Conta
    {
        public override void Saca(double valor)
        {
            if (Saldo < valor)
            {
                throw new SaldoInsuficienteException();
            }
            Saldo -= (valor + 0.10);
        }

        public override void Deposita(double valor)
        {
            if (valor <= 0.0)
            {
                throw new ArgumentException();
            }
            Saldo += valor;
        }
    }
}