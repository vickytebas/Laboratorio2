using System;
using System.Collections.Generic;
using System.Text;

namespace Laboratorio2
{
    class Conta
    {
        //Atributos
        private bool isPoupanca;
        private int numIdentificacao;
        private string nome;
        private float saldoAtual;

        //Construtor
        public Conta(bool isPoupanca, int numIdentificacao, string nome, float saldoAtual)
        {
            this.isPoupanca = isPoupanca;
            this.numIdentificacao = numIdentificacao;
            this.nome = nome;
            this.saldoAtual = saldoAtual;
        }

        //Encapsulamento
        public bool IsPoupanca { get => isPoupanca; }
        public int NumIdentificacao { get => numIdentificacao; }
        public string Nome { get => nome; }
        public float SaldoAtual { get => saldoAtual; set => saldoAtual = value; }

        //Metodos
        public void SacarDinheiro(float saque)
        {
            float tarifaSaque = 0;

            if (SaldoAtual > 0)
            {
                if (IsPoupanca == true)
                {
                    tarifaSaque = saque * 0.2f;
                }
                else
                {
                    tarifaSaque = saque * 0.37f;
                }

                if (saque + tarifaSaque > SaldoAtual)
                {
                    Console.Write("{0}, saldo insuficiente para o saque. Operacao cancelada.", Nome);
                    Console.ReadLine();
                }
                else
                {
                    SaldoAtual -= saque + tarifaSaque;
                }
            }
        }

        public void DepositarDinheiro(float deposito)
        {
            SaldoAtual += deposito;
        }

        public void TransferirDinheiro(float transferencia, Conta receptor)
        {
            float tarifaTransferencia = 0;

            if (IsPoupanca == true)
            {
                tarifaTransferencia = transferencia * 0.15f;
            }
            else
            {
                tarifaTransferencia = transferencia * 0.1f;
            }

            if (transferencia + tarifaTransferencia > saldoAtual)
            {
                Console.Write("{0}, saldo insuficiente para a transferencia. Operacao cancelada.", Nome);
                Console.ReadLine();
            }
            else
            {
                SaldoAtual -= transferencia + tarifaTransferencia;
                receptor.SaldoAtual += transferencia;
            }
        }

        public void ChecarDinheiro()
        {
            Console.Write("{0}", SaldoAtual);
            Console.ReadLine();
        }
    }
}