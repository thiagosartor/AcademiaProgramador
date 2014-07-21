using System;
using Unidade2.Orientado_a_Objetos;

namespace Unidade2.Relacoes
{
    class TestaContaEAgencia
    {
        private static void Main()
        {
            //Criando objetos
            Agencia a = new Agencia();
            a.numero = 2314324;

            // Carregando dados
            ContaEAgencia c1 = new ContaEAgencia();
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