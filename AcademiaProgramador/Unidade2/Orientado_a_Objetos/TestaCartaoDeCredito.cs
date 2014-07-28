namespace Unidade2.Orientado_a_Objetos
{
    internal class TestaCartaoDeCredito
    {
        private static void Main_()
        {
            //Criando objetos
            //CartaoDeCredito cdc = new CartaoDeCredito();
            //cdc.numero = 11111;

            //Agencia a = new Agencia(1234);
            //Conta c = new Conta();

            Agencia a = new Agencia(1234);
            Conta c = new Conta(a);

            //CartaoDeCredito cdc = new CartaoDeCredito(11111);

            //cdc.dataDeValidade = "12/17";

            //// Populando objetos
            //Cliente c = new Cliente();
            //c.codigo = 234324;
            //c.nome = "Thiago Saretor";

            //// Populando objetos
            //CartaoDeCredito cdc2 = new CartaoDeCredito();
            //cdc2.numero = 098765676;
            //cdc2.dataDeValidade = "12/18";

            //// Ligando os objetos
            //cdc.cliente = c;

            //System.Console.WriteLine(cdc2.numero);
            //System.Console.WriteLine(cdc2.dataDeValidade);
            //System.Console.WriteLine(cdc2.cliente.nome);
        }
    }
}