using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Estudo_de_Classes
{

    
    class Class1 
    {

        public string Nome { get; set; }
        public string Curso { get; set; }
        public double Nota1 { get; set; }
       
        public double Nota2 { get; set; }
        public double Resultado { get ; set; }

       

        public double Calcular()
        {
            Resultado = (Nota1 + Nota2) / 2;
            return Resultado;

        }

     

        public string Imprimir()
        {
            string texto = "Nome:  " +Nome +"       Curso:  "+Curso + "       Nota 1:  " + Nota1 + "        Nota 2:  " + Nota2 + "          Media:  " + Resultado;
            return texto;
        }

        public bool Verificar()
        {
            if ( Resultado >= 7)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        
        public string ImprimeAprovado()
        {
            string texto = " APROVADO ";
            return texto;
        }
        public string ImprimeReprovado()
        {
            string texto = " REPROVADO ";
            return texto;
        }
    }
}
