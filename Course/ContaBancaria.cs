using System.Globalization;

namespace Course {
    class ContaBancaria {

        public int NumConta { get; }
        public string Titular { get; set; }
        public double Saldo { get; private set; }

        public ContaBancaria(int numConta, string titular, double valorDeposito) {
            NumConta = numConta;
            Titular = titular;
            Saldo = valorDeposito;
        }

        public ContaBancaria(int numConta, string titular) {
            NumConta = numConta;
            Titular = titular;
        }

        public void Deposito(double valor) {
            Saldo += valor;
        }

        public void Saque(double valor) {
            Saldo -= valor + 5.00;
        }

        public override string ToString() {
            return $"Conta: {NumConta}, Titular: {Titular}, Saldo: {Saldo.ToString("F2", CultureInfo.InvariantCulture)}";
        }
    }
}
