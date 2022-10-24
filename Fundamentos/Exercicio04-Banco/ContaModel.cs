using Exercicio04_Banco.Helper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio04_Banco {
    public class ContaModel {
        private double Saldo { get; set; }
        public string NomeTitular { get; set; }
        public int NumeroConta { get; private set; }
    
        
        public ContaModel(string nomeTitular) {
            NumeroConta = GeradorNumeroConta();
            NomeTitular = nomeTitular;
        }

        public ContaModel(string nomeTitular, double depositoInicial) {
            NumeroConta = GeradorNumeroConta();
            NomeTitular = nomeTitular;
            Saldo = depositoInicial;
        }

        private int GeradorNumeroConta() {
            Random random = new Random();
            int numConta = random.Next(10000,99999);

            return numConta;
        }

        public double ConsultaSaldo() {
            return this.Saldo;
        }

        public void Deposito(double deposito) {
            Saldo += deposito;
        }

        public void Saque(double saque) { 
            Saldo -= (saque - 5);
        }

        public string Extrato(int numeroConta) {
            var conta = DataBase.listaDeContas[numeroConta];

            return $"Extrato \n cc:{conta.NumeroConta}\n Titular: {conta.NomeTitular} \n Saldo R$ {conta.ConsultaSaldo}";
        }

        public void MudarNome(string novoNome) {
            this.NomeTitular = novoNome;
        }
    }

}
