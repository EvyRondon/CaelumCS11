namespace POO
{
    public abstract class Conta
    {
        public int Numero { get; set; }
        public Cliente Titular { get; set; }
        public double Saldo { get; protected set; }

        public abstract void Deposita(double valor);
        //{
        //    Saldo += valor;
        //}

        public abstract bool Saca(double valor);
        //{
        //    if (Saldo >= valor) {
        //        Saldo -= valor;
        //        return true;
        //    }
        //    return false;
        //}

        public void Transfere(double valor, Conta destino)
        {
            if (Saca(valor)) {
                destino.Deposita(valor);
            }
        }
    }
}
