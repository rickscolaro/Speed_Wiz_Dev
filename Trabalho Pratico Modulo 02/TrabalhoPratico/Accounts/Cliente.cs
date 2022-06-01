using System.Globalization;

namespace TrabalhoPratico.Accounts {

    public class Cliente {


        public Cliente(string nome, string rg, string cpf, string endereco) {
            Nome = nome;
            Rg = rg;
            Cpf = cpf;
            Endereco = endereco;
        }

        public string Nome { get; set; }

        public string Rg { get; set; }

        public string Cpf { get; set; }

        public string Endereco { get; set; }


        double taxaDeRetorno = 0.01;
        public void ValorInvestido(double investimento) {

            for (int i = 1; i <= 12; i++) {

                investimento = investimento + (investimento * taxaDeRetorno);
            }
            System.Console.WriteLine("Resultado de investimento apos 12 meses com taxa de 1% ao ano: R$"+investimento.ToString("F2"));

        }

    }
}