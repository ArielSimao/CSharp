using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApplication1
{
    class Funcionario
    {
        public string nome;
        public int qtdHoras;
        public int valorHora;
        public double salario;

        public double calcular()
        {
            salario = this.qtdHoras * this.valorHora;
            return salario;
        }

    }
}
