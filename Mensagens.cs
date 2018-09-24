using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07_BiroBank {
    class Mensagens {
        public void BoasVindas() {
            Console.WriteLine("#####################################################");
            Console.WriteLine("#                                                   #");
            Console.WriteLine("#    Bem-vindo(a) ao Biro Bank - O Banco Digital    #");
            Console.WriteLine("#                                                   #");
            Console.WriteLine("#####################################################");
            Console.WriteLine();
        }

        public void MostrarConta(string titular, int agencia, int numero, double saldo) {

            string saldoConvertido = string.Format("{0:0,0.00}", saldo);
            
            Console.WriteLine($"Bem-vindo(a) {titular} !");
            Console.WriteLine($"Agencia: {agencia}");
            Console.WriteLine($"Numero da conta: {numero}");
            Console.WriteLine($"Saldo Disponivel: R${saldoConvertido}");
            Console.WriteLine();
        }
    }
}
