using System;

namespace controleContas
{
    class Program
    {
        static void Main(string[] args)
        {
            Banco banco = new Banco();
            banco.NumeroBanco = 1;
            banco.Nome = "Itau";

            Agencia agencia = new Agencia();
            agencia.NumeroAgencia = 123;
            agencia.CEP = "27211-670";
            agencia.Telefone = "99941-1138";
            agencia.BancoVinculado = banco;

            Cliente cliente1 = new Cliente();
            cliente1.Nome = "Flavio";
            cliente1.CPF = "01234567890";
            cliente1.AnoNascimento = 2000;

            Conta conta1 = new Conta(cliente1, agencia, 10.0m);
            conta1.NumeroProp = 123456;
            conta1.SaldoProp = 1235.42m;

            Conta conta2 = new Conta(cliente1, agencia, 100.0m);
            conta2.NumeroProp = 654321;
            conta2.SaldoProp = 2341.42m;

            Console.WriteLine("Conta do cliente '{0}', CPF: {1}, Nascido no ano: {2}, Número: {3}, Saldo: {4:C2}",
            cliente1.Nome, cliente1.CPF, cliente1.AnoNascimento, conta1.NumeroProp, conta1.SaldoProp);

            Console.WriteLine("Conta do cliente '{0}', CPF: {1}, Nascido no ano: {2}, Número: {3}, Saldo: {4:C2}",
            cliente1.Nome, cliente1.CPF, cliente1.AnoNascimento, conta2.NumeroProp, conta2.SaldoProp);
            
            decimal saldoTotal = conta1.SaldoProp + conta2.SaldoProp;
            Console.WriteLine("Saldo total das duas contas: {0:C2}", saldoTotal);

            Conta contaComMaiorSaldo = (conta1.SaldoProp > conta2.SaldoProp) ? conta1 : conta2;
            Console.WriteLine("A conta '{0}' com {1:C2} é a que mais tem saldo", contaComMaiorSaldo.NumeroProp, contaComMaiorSaldo.SaldoProp);

            decimal saldoInicialTotalGeral = conta1.SaldoInicialProp + conta2.SaldoInicialProp;
            Console.WriteLine("Saldo inicial total geral: {0:C2}", saldoInicialTotalGeral);
            Console.WriteLine();

            decimal valorSaque = 500.0m;
            conta1.Saque(valorSaque);

            conta1.Transferencia(conta2, 10.0m);

            Console.Read();
        }
    }
}
