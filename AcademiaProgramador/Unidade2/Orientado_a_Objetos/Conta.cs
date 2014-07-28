namespace Unidade2.Orientado_a_Objetos
{
    internal class Conta
    {
        public int numero;
        public double saldo;
        public double limite = 100;
        public Agencia agencia;

        // Adicione o contrutor abaixo

        public Conta(Agencia agencia)
        {
            this.agencia = agencia;
        }

        public Conta()
        {
            // TODO: Complete member initialization
        }

        public void Transfere(Conta destino, double valor)
        {
            this.saldo -= valor;
            destino.saldo += valor;
        }

        public void Deposita(double valor)
        {
            this.saldo += valor;
        }

        public void Saca(double valor)
        {
            this.saldo -= valor;
        }

        public void ImprimeExtrato()
        {
            System.Console.WriteLine(" SALDO : " + this.saldo);
        }

        public double ConsultaSaldoDisponivel()
        {
            return this.saldo + this.limite;
        }
    }
}