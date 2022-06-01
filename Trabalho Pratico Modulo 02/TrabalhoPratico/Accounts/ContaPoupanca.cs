using System;

namespace TrabalhoPratico.Accounts {

    public class ContaPoupanca : Conta {

        public ContaPoupanca(
            int numeroDaAgencia,
            decimal numeroDaConta,
            Cliente nomeDoTitular,
            decimal saldoDaConta) : base(numeroDaAgencia, numeroDaConta, nomeDoTitular, saldoDaConta) {


        }

        decimal taxaDeTributo = 0.03m;
        decimal total = 0;
        public decimal CalcularTributo() {

            return total = SaldoDaConta * taxaDeTributo;
            System.Console.WriteLine("O tributo pago de 3% sobre saldo é: ");

        }
    }
}