namespace WpfApplication1
{
     class Pessoa
    {
        

        public int idade { get;set; }
        public string nome { get;set; }
   
        public string sexo { get; set; }

        public bool isMaior()
        {
            if(idade >= 18)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool Sexo()
        {
            if (txtSexo >= 18)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public string imprimeMaior()
        {
            string texto = " Você É maior! ";
            return texto;
        }
        public string imprimeMenor()
        {
            string texto = " Você É menor! ";
            return texto;
        }

        public string imprimePar()
        {
            string texto = " Idade é Par! ";
            return texto;
        }
        public string imprimeImpar()
        {
            string texto = " Idade é Impar! ";
            return texto;
        }

        public string imprimeMasc()
        {
            string texto = " Sexo Masculino! ";
            return texto;
        }
        public string imprimeFem()
        {
            string texto = " Sexo Feminino! ";
            return texto;
        }
    }
}