using System;

namespace Unidade2.Orientado_a_Objetos
{
    class TestaAgencia
    {
        private static void Main_()
        {
            Agencia a = new Agencia(123123);

            a.numero = 1234;

            Agencia a2 = new Agencia();
            a2.numero = 5678;

            Console.WriteLine(a.numero);

            Console.WriteLine(a2.numero);

            //Chamando o primeiro construtor
            Pessoa p1 =new Pessoa("23423423");

            //Chamando o segundo construtor
            Pessoa p2 = new Pessoa(23423423);
        }
    }
}