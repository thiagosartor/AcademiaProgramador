namespace Unidade2.Orientado_a_Objetos
{
    class TestaCartaoDeCredito
    {
        private static void Main_()
        {
            //Criando objetos
            CartaoDeCredito cdc1 = new CartaoDeCredito();
            cdc1.numero = 114532543;
            cdc1.dataDeValidade = "12/17";

            // Populando objetos
            Cliente c = new Cliente();
            c.codigo = 234324;
            c.nome = "Thiago Saretor";

            // Populando objetos
            CartaoDeCredito cdc2 = new CartaoDeCredito();
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