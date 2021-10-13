﻿namespace ByteBank
{
    public class ContaCorrente
    {
        public static double TaxaOperacao { get; private set; }
        public Cliente Titular { get; set; }
        public static int TotalDeContasCriadas { get; private set; }
        private int _agencia;
        public int Numero { get; set; }
        private double _saldo = 100;

        public int Agencia
        {
            get => _agencia;
            set
            {
                if( value <= 0 )
                {
                    return;
                }

                _agencia = value;
            }
        }

        public double Saldo
        {
            get => _saldo;
            set
            {
                if( value < 0 )
                {
                    return;
                }
                _saldo = value;
            }
        }

        public ContaCorrente( int agencia, int numero )
        {
            Agencia = agencia;
            Numero = numero;
            TaxaOperacao = 30 / TotalDeContasCriadas;
            TotalDeContasCriadas++;
        }

        public bool Sacar( double valor )
        {
            if( _saldo < valor )
            {
                return false;
            }

            _saldo -= valor;
            return true;
        }

        public void Depositar( double valor ) => _saldo += valor;

        public bool Transferir( double valor, ContaCorrente contaDestino )
        {
            if( _saldo < valor )
            {
                return false;
            }

            _saldo -= valor;
            contaDestino.Depositar( valor );
            return true;
        }
    }
}