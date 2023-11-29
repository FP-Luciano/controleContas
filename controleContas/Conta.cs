using System;

namespace controleContas
{
    class Conta
    {
        private int numero;
        private decimal saldo;
        private Cliente titular;
        private Agencia agencia;

        public int NumeroProp { get; set; }

        public decimal SaldoInicialProp { get; set; }

        public Cliente Titular
        {
            get { return titular; }
            set { titular = value; }
        }
        public Agencia AgenciaVinculada
        {
            get { return agencia; }
            set { agencia = value; }
        }

        public Conta(Cliente titularConta, Agencia agenciaConta, decimal saldoInicial)
        {
            if (titularConta == null || agenciaConta == null)
            {
                throw new ArgumentException("O titular e a agência da conta deve ser fornecido.");
            }

            Titular = titularConta;
            AgenciaVinculada = agenciaConta;
            
            if (saldoInicial >= 10.0m)
            {
                SaldoProp = saldoInicial;
                SaldoInicialProp = SaldoProp;
            }
            else
            {
                Console.WriteLine("O saldo inicial deve ser superior a R$10,00. A conta não foi criada.");
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
            decimal valorTaxa = 0.10m;
            decimal valorSaqueComTaxa = valor + valorTaxa;

            if (valorSaqueComTaxa > 0 && SaldoProp - valorSaqueComTaxa >= 0)
            {
                SaldoProp -= valorSaqueComTaxa;
                Console.WriteLine("Saque de {0:C2} realizado com sucesso.", valor);
                Console.WriteLine("Taxa cobrada: {0:C2}. Novo saldo: {1:C2}", valorTaxa, SaldoProp);
                return SaldoProp;                
            }
            else
            {
                Console.WriteLine("Não foi possível realizar o saque. Verifique o valor informado ou o saldo disponível.");
                return SaldoProp;
            }
        }

        public void Transferencia(Conta contaDestino, decimal valor)
        {
            if (valor > 0 && SaldoProp - valor >= 0)
            {
                SaldoProp -= valor;
                contaDestino.SaldoProp += valor;
                Console.WriteLine("Transferência de {0:C2} para conta '{1}' realizada com sucesso.", valor, contaDestino.NumeroProp);
                Console.WriteLine("Novo saldo da conta atual: {0:C2}", SaldoProp);
                Console.WriteLine("Novo saldo da conta de destino: {0:C2}", contaDestino.SaldoProp);
            }
            else
            {
                Console.WriteLine("Não foi possível realizar a transferência. Verifique o valor informado ou o saldo disponível.");
            }
        }
    }
}
