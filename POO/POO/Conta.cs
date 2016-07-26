namespace POO
{
    public class Conta
    {
        public int Numero { get; set; }
        public Cliente Titular { get; set; }
        public double Saldo { get; private set; }

        public virtual void Deposita(double valor)
        {
            Saldo += valor;
        }

        public virtual bool Saca(double valor) {
            if (Saldo >= valor) {
                Saldo -= valor;
                return true;
            }
            return false;
        }

        public void Transfere(double valor, Conta destino)
        {
            if (Saca(valor)) {
                destino.Deposita(valor);
            }
        }
    }
}
