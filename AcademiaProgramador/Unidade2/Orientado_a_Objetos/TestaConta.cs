using System;

namespace Unidade2.Orientado_a_Objetos
{
    class TestaConta
    {
        private static void Main_()
        {
            //Criando objetos
            Agencia a = new Agencia();
            a.numero = 2314324;

            // Carregando dados
            Conta c1 = new Conta();
            c1.numero = 1234;
            c1.saldo = 1000;
            c1.limite = 500;

            //Ligando os objetos
            c1.agencia = a;

            Console.WriteLine(c1.numero);
            Console.WriteLine(c1.saldo);
            Console.WriteLine(c1.limite);
            Console.WriteLine(c1.agencia.numero);
        }
    }
}