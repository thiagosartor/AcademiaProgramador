namespace Unidade2.Orientado_a_Objetos
{
    internal class Conta
    {
        public int numero;
        public double saldo;
        public double limite = 100;

        //Adiciona a linha abaixo
        public Agencia agencia;

        public void Deposita(double valor)
        {
            this.saldo += valor;
        }

        public double ConsultaSaldoDisponivel()
        {
            return this.saldo + this.limite;
        }
    }
}