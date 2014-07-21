using Unidade2.Orientado_a_Objetos;

namespace Unidade2.Relacoes
{
    class TestaCartaoECliente
    {
        private static void Main_()
        {
            //Criando objetos
            CartaoECliente cdc1 = new CartaoECliente();
            cdc1.numero = 114532543;
            cdc1.dataDeValidade = "12/17";

            // Populando objetos
            Cliente c = new Cliente();
            c.codigo = 234324;
            c.nome = "Thiago Saretor";

            // Populando objetos
            CartaoECliente cdc2 = new CartaoECliente();
            cdc2.numero = 098765676;
            cdc2.dataDeValidade = "12/18";

            // Ligando os objetos
            cdc1.cliente = c;

            System.Console.WriteLine(cdc2.numero);
            System.Console.WriteLine(cdc2.dataDeValidade);
            System.Console.WriteLine(cdc2.cliente.nome);
        }
    }
}