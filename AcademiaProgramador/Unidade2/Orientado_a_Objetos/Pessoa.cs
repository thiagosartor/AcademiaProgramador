using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Unidade2.Orientado_a_Objetos
{
    class Pessoa
    {
        public string rg;
        public int cpf;

        public Pessoa(string rg)
        {
            this.rg = rg;
        }

        public Pessoa(int cpf)
        {
            this.cpf = cpf;
        }

    }
}