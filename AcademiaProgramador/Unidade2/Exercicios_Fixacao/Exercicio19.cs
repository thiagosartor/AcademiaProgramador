using System;

namespace Unidade2.Exercicios_Fixacao
{
    class TestaGerente
    {
        private static void Main_()
        {
            Gerente g = new Gerente();
            g.salario = 1000;

            Console.WriteLine(" Salário : " + g.salario);

            Console.WriteLine(" Aumentando o salário em 10% ");
            g.AumentaSalario();

            Console.WriteLine(" Salário : " + g.salario);

            Console.WriteLine(" Aumentando o salário em 30% ");
            g.AumentaSalario(0.3);

            Console.WriteLine(" Salário : " + g.salario);
        }
    }
}