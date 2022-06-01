using System;

namespace TrabalhoPratico.Accounts {

    public class Conta {

        public int NumeroDaAgencia { get; set; }

        public decimal NumeroDaConta { get; set; }

        public Cliente NomeDoTitular { get; set; }

        public decimal SaldoDaConta { get; set; }


        public Conta(int numeroDaAgencia, decimal numeroDaConta, Cliente nomeDoTitular, decimal saldoDaConta) {

            NumeroDaAgencia = numeroDaAgencia;
            NumeroDaConta = numeroDaConta;
            NomeDoTitular = nomeDoTitular;
            SaldoDaConta = saldoDaConta;
        }

        public void ValorSaque(decimal saque) {

            if (SaldoDaConta >= saque) {

                SaldoDaConta = SaldoDaConta - saque;
                System.Console.WriteLine("Operação realizada com sucesso!");
                System.Console.WriteLine($"Dados da conta atualizados. Saldo Total: R${SaldoDaConta}");

            } else {
                System.Console.WriteLine("Saldo Insuficiente para saque.");
                System.Console.WriteLine($"Saldo atual: R${SaldoDaConta}");
            }
        }

        public void ValorDeposito(decimal deposito) {

            if (deposito > 0) {

                SaldoDaConta = SaldoDaConta + deposito;
                System.Console.WriteLine("Operação realizada com sucesso!");
                System.Console.WriteLine($"Dados da conta atualizados. Saldo Total: R${SaldoDaConta}");
            } else {

                System.Console.WriteLine("Operação não permitida.");
            }
        }

        public void Transferir(decimal valorTransferencia, Conta contadestino, Conta contaDeSaque) {

            if (valorTransferencia < contaDeSaque.SaldoDaConta) {

                ValorSaque(valorTransferencia);
                contadestino.ValorDeposito(valorTransferencia);
                System.Console.WriteLine();
                System.Console.WriteLine($"Saldo da conta de destino R${contadestino.SaldoDaConta.ToString("F2")}");
                System.Console.WriteLine($"Saldo da conta de saque R${contaDeSaque.SaldoDaConta.ToString("F2")}");

            } else {

                System.Console.WriteLine("Saldo da conta para transferência é insuficiente para o valor da operação.");
                 System.Console.WriteLine($"Saldo da conta de saque R${contaDeSaque.SaldoDaConta.ToString("F2")}");
                 System.Console.WriteLine($"Valor da operação de transferência R${valorTransferencia}");
            }

        }

    }
}