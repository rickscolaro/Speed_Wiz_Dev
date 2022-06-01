namespace TrabalhoPratico.Accounts {

    public class ContaInvestimento : Conta {


        public ContaInvestimento(
            int numeroDaAgencia,
            decimal numeroDaConta,
            Cliente nomeDoTitular,
            decimal saldoDaConta) : base(numeroDaAgencia, numeroDaConta, nomeDoTitular, saldoDaConta) {

        }


        decimal taxaDTibuto = 0.15m;

        public decimal CalcularTributo() {

             return SaldoDaConta * taxaDTibuto;
             

        }


    }
}