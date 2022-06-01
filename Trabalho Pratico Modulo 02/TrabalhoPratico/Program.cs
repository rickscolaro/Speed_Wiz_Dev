using System;
using System.Globalization;

using TrabalhoPratico.Accounts;
using TrabalhoPratico.Operations;

namespace MyApp {

    internal class Program {

        static void Main(string[] args) {
            System.Console.WriteLine("\n");

            Cliente contaCliente = new Cliente("Ricardo Reis", "25.033.266-8", "44725504415", "Rua Bom Retiro 460 Joinville SC");

            Conta contaBancaria = new Conta(551, 4392671905523995, contaCliente, 20000);

            Conta contaDestino = new Conta(551, 42547891245444567, contaCliente, 30000);

            ContaPoupanca contaPoupanca = new ContaPoupanca(441, 4392671905523995, contaCliente, 20000);

            ContaInvestimento contaInvestimento = new ContaInvestimento(442, 4388871905524458, contaCliente, 20000);


            System.Console.WriteLine("      RICARDOBANK");
            System.Console.WriteLine();

            System.Console.WriteLine($"Cliente: " + contaBancaria.NomeDoTitular.Nome);
            System.Console.WriteLine($"Agencia: " + contaBancaria.NumeroDaAgencia);
            System.Console.WriteLine($"Saldo da conta: R$" + contaBancaria.SaldoDaConta.ToString("F2"));

            Windon.Janela();


            bool loopBreak = true;
            while (loopBreak) {

                int escolha = JoiceOperation.EscolhaOperacao();
                switch (escolha) {

                    case 1:
                        System.Console.Write("Informe o valor do Saque: ");
                        decimal saque = decimal.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                        contaBancaria.ValorSaque(saque);
                        break;

                    case 2:
                        System.Console.Write("Informe o valor do deposito: ");
                        decimal deposito = decimal.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                        contaBancaria.ValorDeposito(deposito);
                        break;

                    case 3:
                        System.Console.WriteLine($"O saldo da conta de transferência é : R$" + contaDestino.SaldoDaConta);
                        System.Console.WriteLine("Digite o valor de transferência Bancaria: ");
                        decimal transferencia = decimal.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                        contaBancaria.Transferir(transferencia, contaDestino, contaBancaria);
                        break;

                    case 4:
                        System.Console.WriteLine("Informe o valor de Investimento: ");
                        double investimento = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                        contaCliente.ValorInvestido(investimento);

                        break;

                    case 5:
                        System.Console.WriteLine($"O tributo pago para conta {contaPoupanca.NumeroDaConta} sera de: R$" + contaInvestimento.CalcularTributo().ToString("F2"));
                        System.Console.WriteLine($"O tributo pago para conta {contaInvestimento.NumeroDaConta} sera de: R$" + contaPoupanca.CalcularTributo().ToString("F2"));
                        break;

                    case 6:
                        System.Console.WriteLine("Obrigado pela preferencia!");
                        Console.ReadKey();
                        break;

                    default:
                        System.Console.WriteLine("Operação invalida!");
                        break;

                }
                Windon.Janela();

                if (escolha == 6) {

                    loopBreak = false;
                }


            }



            System.Console.WriteLine("\n");
        }
    }
}