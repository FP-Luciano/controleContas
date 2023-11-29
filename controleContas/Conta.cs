using System;

namespace controleContas
{
    class Conta
    {
        private int numero;
        private decimal saldo;
        private Cliente titular;

        public int NumeroProp { get; set; }

        public decimal SaldoInicialProp { get; set; }

        public Cliente Titular
        {
            get { return titular; }
            set { titular = value; }
        }

        public Conta(Cliente titularConta, decimal saldoInicial)
        {
            Titular = titularConta;
            
            if (saldoInicial >= 10.0m)
            {
                SaldoProp = saldoInicial;
                SaldoInicialProp = SaldoProp;
            }
            else
            {
                Console.WriteLine("O saldo inicial deve ser superiora R$10,00. A conta não foi criada.");
            }
        }

        public decimal SaldoProp
        {
            get { return saldo; }
            set
            {
                if (value >= 0.0m)
                {
                    saldo = value;
                }
                else
                {
                    Console.WriteLine("O saldo nao pode ser definido como negativo.");
                }
            }
        }

        public decimal Saque(decimal valor)
        {
            if (valor > 0 && SaldoProp - valor >= 0)
            {
                SaldoProp -= valor;
                Console.WriteLine("Saque de {0:C2} realizado com sucesso. Novo saldo: {1:C2}", valor, SaldoProp);
                return SaldoProp;
            }
            else
            {
                Console.WriteLine("Não foi possível realizar o saque. Verifique o valor informado ou o saldo disponível.");
                return SaldoProp;
            }
        }
    }
}
