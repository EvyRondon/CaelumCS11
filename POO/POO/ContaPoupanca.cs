namespace POO
{
    class ContaPoupanca : Conta
    {
        public override bool Saca(double valor)
        {
            if (Saldo >= valor)
            {
                Saldo -= (valor + 0.10);
                return true;
            }
            return false;
        }

        public override void Deposita(double valor)
        {
            Saldo += valor;
        }
    }
}