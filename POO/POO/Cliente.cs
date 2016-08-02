namespace Banco
{
    public class Cliente
    {
        public string Nome { get; set; }
        public string Rg { get; set; }
        public string Cpf { get; set; }
        public string Endereco { get; set; }
        public int Idade { get; set; }

        public Cliente(string nome, string rg)
        {
            Nome = nome;
            Rg = rg;
        }

        public bool EhMaiorDeIdade() {
            if(Idade > 18)
            {
                return true;
            }
            return false;
        }

        public override bool Equals(object obj)
        {
            Cliente outroCliente = (Cliente)obj;
            return this.Nome == outroCliente.Nome && this.Rg == outroCliente.Rg;
        }
    }
}
