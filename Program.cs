using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07_BiroBank {
    class Program {
        static void Main(string[] args) {
            Mensagens mensagem = new Mensagens();
            mensagem.BoasVindas();

            Cliente jandira = new Cliente("Jandira", "00000000000", "Programadora");
            ContaCorrente conta = new ContaCorrente(jandira, -10, 86718659);
                       
            Cliente gabriela = new Cliente("Gabriela", "11111111111", "Programadora");
            ContaCorrente contaGabriela = new ContaCorrente(gabriela, 111186, 86719538);

            Cliente gabriel = new Cliente("Gabriel", "11111111122", "Programador");
            ContaCorrente contaGabriel = new ContaCorrente(gabriel, 111187, 86719539);


            Console.WriteLine(ContaCorrente.TotalDeContasCriadas + "\n");

            mensagem.MostrarConta(
               conta.Titular.Nome, conta.Agencia, conta.Numero, conta.Saldo
            );

            mensagem.MostrarConta(
               contaGabriela.Titular.Nome, contaGabriela.Agencia, contaGabriela.Numero, contaGabriela.Saldo
            );

            mensagem.MostrarConta(
               contaGabriel.Titular.Nome, contaGabriel.Agencia, contaGabriel.Numero, contaGabriel.Saldo
            );



        }
    }
}
