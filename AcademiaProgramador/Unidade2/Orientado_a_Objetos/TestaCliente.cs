namespace Unidade2.Orientado_a_Objetos
{
    class TestaCliente
    {
        private static void Main_()
        {
            Cliente c1 = new Cliente();
            c1.nome = " Thiago Sartor ";
            c1.codigo = 1;

            Cliente c2 = new Cliente();
            c2.nome = " Alexandre Rech ";
            c2.codigo = 2;

            System.Console.WriteLine(c1.nome);
            System.Console.WriteLine(c1.codigo);

            System.Console.WriteLine(c2.nome);
            System.Console.WriteLine(c2.codigo);
        }
    }
}