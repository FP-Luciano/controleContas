using System;

namespace controleContas
{
    class Cliente
    {
        private string nome;
        private string cpf;
        private int anoNascimento;

        public string Nome
        {
            get { return nome; }
            set { nome = value; }
        }

        public string CPF
        {
            get { return cpf; }
            set
          {
                if (value.Length == 11)
                {
                    cpf = value;
                }
                else
                {
                    Console.WriteLine("O CPF deve conter 11 dígitos.");
                }
            }
        }

        public int AnoNascimento
        {
            get { return anoNascimento; }
            set
            {
                if (DateTime.Now.Year - value > 18)
                {
                    anoNascimento = value;
                }
                else
                {
                    Console.WriteLine("O cliente deve ter mais de 18 anos.");
                }
            }
        }
    }
}