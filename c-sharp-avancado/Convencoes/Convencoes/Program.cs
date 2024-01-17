using System;

namespace Convencoes
{
    class ContaBancaria
    {
        public string Titular { get; set; }
        private double _saldo;

        public void Deposito(double valor)
        {
            _saldo += valor;
        }

        public double GetSaldo()
        {
            return _saldo;
        }
    }    
}