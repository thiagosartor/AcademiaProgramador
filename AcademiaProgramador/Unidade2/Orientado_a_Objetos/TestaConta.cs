using System;

namespace Unidade2.Orientado_a_Objetos
{
    internal class TestaConta
    {
        private static void Main_()
        {
            Conta c = new Conta();

            c.Deposita(1000);
            c.ImprimeExtrato();

            c.Saca(100);
            c.ImprimeExtrato();

            Conta origem = new Conta();
            origem.saldo = 1000;

            Conta destino = new Conta();

            origem.Transfere(destino, 500);

            Console.WriteLine(origem.saldo);
            Console.WriteLine(destino.saldo);

            double saldoDisponivel = c.ConsultaSaldoDisponivel();
            Console.WriteLine(" SALDO DISPONÍVEL : " + saldoDisponivel);
        }
    }
}


