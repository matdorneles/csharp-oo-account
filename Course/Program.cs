using Course;
using System.Globalization;

namespace Aulas {
    class Aulas {
        static void Main(string[] args) {

            ContaBancaria Conta;
            int numConta;
            string titular;
            char depositoInicial;
            bool deposito;
            double valorDeposito;
            double valorSaque;

            Console.Write("Informe o número da conta: ");
            numConta = int.Parse(Console.ReadLine());

            Console.Write("Informe o titular da conta: ");
            titular = Console.ReadLine();

            Console.Write("Haverá depósito inicial (s/n)? ");
            depositoInicial = char.Parse(Console.ReadLine());
            if (depositoInicial == 's')
                deposito = true;
            else deposito = false;

            if (deposito) {
                Console.Write("Informe o valor do depósito: ");
                valorDeposito = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                Conta = new ContaBancaria(numConta, titular, valorDeposito);
            }
            else Conta = new ContaBancaria(numConta, titular);

            Console.WriteLine("Dados da conta: ");
            Console.WriteLine(Conta);

            Console.Write("Entre um valor para depósito: ");
            valorDeposito = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Conta.Deposito(valorDeposito);
            Console.WriteLine("Dados da conta atualizados: ");
            Console.WriteLine(Conta);

            Console.Write("Entre um valor para saque: ");
            valorSaque = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Conta.Saque(valorSaque);
            Console.WriteLine("Dados da conta atualizados: ");
            Console.WriteLine(Conta);
        }
    }
}
