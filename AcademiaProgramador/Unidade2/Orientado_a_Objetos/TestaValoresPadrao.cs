namespace Unidade2.Orientado_a_Objetos
{
    internal class TestaValoresPadrao
    {
        private static void Main_()
        {
            // Conta c = new Conta();

            //Console.WriteLine(c.numero);
            //Console.WriteLine(c.saldo);
            //Console.WriteLine(c.limite);

            // Criando um objeto de cada classe
            CartaoDeCredito cdc = new CartaoDeCredito();
            Cliente c = new Cliente();

            // Ligando os objetos
            cdc.cliente = c;

            // Acessando o nome do cliente
            cdc.cliente.nome = "Thiago Sartor";
        }
    }
}