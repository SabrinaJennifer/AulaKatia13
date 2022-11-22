using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AulaKatia13
{
    public class Conta
    {
        public string Titular { get; set; }
        public string Agencia { get; set; }
        public string Numero { get; set; }
        public double Saldo { get; set; }
        public void Depositar(double valor)
        {
            this.Saldo += valor;
        }
    }
}
